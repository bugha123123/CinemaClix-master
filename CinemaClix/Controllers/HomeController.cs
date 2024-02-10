
using CinemaClix.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CinemaClix.Controllers
{
    public class HomeController : Controller
    {
     private readonly ISubscriptionService _subscriptionService;

        public HomeController(ISubscriptionService subscriptionService)
        {
            _subscriptionService = subscriptionService;
        }

        public IActionResult Index()
        {
            var Subscriptions  = _subscriptionService.GetSubscriptions();
            return View(Subscriptions);
        }

     

       
    }
}
