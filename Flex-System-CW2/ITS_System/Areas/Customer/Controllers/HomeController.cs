using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace FlexAppealFitness.Areas.Customer.Controllers
{
    public class HomeController : Controller
    {
        //Makes this area part of the Customer Area
        [Area("Customer")]
        //Only gives access to users that have the role Customer
        [Authorize(Roles = "Customer")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
