﻿using CinemaClix.Interfaces;
using CinemaClix.Models;
using CinemaClix.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CinemaClix.Controllers
{
    public class AccountController : Controller
    {

        private readonly IUserService _RegisterService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserService _userService;
        public AccountController(IUserService loginService, IHttpContextAccessor httpContextAccessor, IUserService userService)
        {
            _RegisterService = loginService;
            _httpContextAccessor = httpContextAccessor;
            _userService = userService;
        }



        [HttpPost("adduser")]
        public async Task<IActionResult> AddUser([Bind("GmailAddress,UserName,Password")] User createUserViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _RegisterService.AddNewUser(createUserViewModel);
                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    return RedirectToAction("Register", "Account");
                }
            }
            catch (InvalidOperationException ex)
            {
                ViewData["GmailAlreadyExists"] = $"{createUserViewModel.GmailAddress}, this GmailAddress already exists!!!";
                return View("Register", createUserViewModel);
            }
      
        }







        public IActionResult Register()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        // LoginController.cs
        [HttpPost("authlogin")]
        public async Task<IActionResult> AuthLogin([Bind("GmailAddress, Password")] User userInput)
        {
            try
            {
                var user = await _userService.AuthLogin(userInput);

                if (user != null)
                {


                    var token = GenerateToken(user);

                    if (user.Role == "Admin")
                    {
                        var AdminCookieOptions = new CookieOptions
                        {
                            HttpOnly = true,
                            Expires = DateTime.UtcNow.AddHours(8),
                            SameSite = SameSiteMode.None,
                            Secure = true,
                            Path = "/"
                        };
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("IsAdmin", "True", AdminCookieOptions);
                        _httpContextAccessor.HttpContext.Response.Cookies.Append("UserName", user.UserName!, AdminCookieOptions);
                    }


                    var cookieOptions = new CookieOptions
                    {
                        HttpOnly = true,
                        Expires = DateTime.UtcNow.AddHours(1),
                        SameSite = SameSiteMode.None,
                        Secure = true,
                        Path = "/"
                    };


                    _httpContextAccessor.HttpContext.Response.Cookies.Append("Token", token, cookieOptions);
                    _httpContextAccessor.HttpContext.Response.Cookies.Append("UserId", user.Id.ToString(), cookieOptions);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["ErrorMessage"] = "Invalid email/password or Your account is suspended. Please contact support for assistance. ";
                    return View("Login", userInput);
                }
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage2"] = "Error During Login. Try Again Later";
                return View("Login", userInput);
            }
        }

        public IActionResult LogOut()
        {
            _userService.Logout();


            return RedirectToAction("Index", "Home");
        }


        private string GenerateToken(User user)
        {
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
        new Claim(ClaimTypes.Name, user.UserName)
    };

            var secretKey = Encoding.UTF8.GetBytes("YourSecretKeyHere");

            var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken(
                issuer: "Cinema",
                audience: "CinemaClix",
                claims: claims,
                expires: DateTime.UtcNow.AddHours(1),
                signingCredentials: signingCredentials
            );

            // Serialize the token to a string
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenString;
        }

    }
} 