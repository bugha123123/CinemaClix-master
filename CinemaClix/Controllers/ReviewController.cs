﻿using CinemaClix.Interfaces;
using CinemaClix.Models;
using CinemaClix.Services;
using Microsoft.AspNetCore.Mvc;

namespace CinemaClix.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;
        private readonly IMovieService _movieservice;
        public ReviewController(IReviewService reviewService, IMovieService movieservice)
        {
            _reviewService = reviewService;
            _movieservice = movieservice;
        }

        public  IActionResult Reviews(int MovieId)
        {
            var Reviews = _reviewService.GetReviewById(MovieId);
            return View(Reviews);
        }

     

    }
}
