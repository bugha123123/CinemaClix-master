﻿using CinemaClix.Interfaces;
using CinemaClix.Models;
using CinemaClix.Services;
using Microsoft.AspNetCore.Mvc;

namespace CinemaClix.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _subscriptionservice;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public SubscriptionController(ISubscriptionService subscriptionservice, IHttpContextAccessor httpContextAccessor)
        {
            _subscriptionservice = subscriptionservice;
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Subscription(string PlanType)
        {
            var FoundSubscription = _subscriptionservice.GetSubByPlanType(PlanType);
            return View(FoundSubscription);
        }

        public async Task<IActionResult> AdminSubscribedTo()
        {
            var Subscriptions = await _subscriptionservice.GetSubscriptionsForAdmin();
            return View(Subscriptions);
        }

        public async  Task<IActionResult> SubscribedTo()
        {
            var Subscriptions = await _subscriptionservice.GetSubscriptions();
            return View(Subscriptions);
        }

        public async Task<IActionResult> Subscriptions()
        {
            var Subscription = await _subscriptionservice.GetSubscriptionPlansList();
            return View(Subscription);
        }

        [HttpPost("addsubscription")]
        public async Task<IActionResult> AddSubscription(Subscriptions subscriptions, string PlanType)
        {

            var UserCheck = await _subscriptionservice.GetSubscriptionsToCheckIfUserIsValidToAddSubscriptionAsync();

            if (UserCheck == null)
            {
                await _subscriptionservice.AddSubscription(subscriptions, PlanType);
                ViewData["SubscriptionAdded"] = "Purchased";
                return RedirectToAction("SubscribedTo", "Subscription");
            }

         

            return RedirectToAction("SubscribedTo", "Subscription");

     
   
       
        }


        [HttpPost("deletesubscriptionadmin")]
        public async Task<IActionResult> DeleteSubscriptionForAdmin(Subscriptions subscriptions)
        {
            await _subscriptionservice.AdminDeleteSubscriptionById(subscriptions);

            return RedirectToAction("AdminSubscribedTo", "Subscription");
        }

        [HttpPost("deletesubscription")]
        public async Task<IActionResult> DeleteSubscription(Subscriptions subscriptions)
        {
            await _subscriptionservice.DeleteSubscriptionForUser(subscriptions);

            return RedirectToAction("SubscribedTo", "Subscription");
        }


    }
}
