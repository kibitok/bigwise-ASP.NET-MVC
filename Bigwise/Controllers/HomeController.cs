using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bigwise.Models;

namespace Bigwise.Controllers
{
    public class HomeController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RegistrationForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegistrationForm(Registration registration)
        {
            // TODO: Email response to the subscription
            if (ModelState.IsValid)
            {
                return View("Thanks", registration);
            }
            else
            {
                //there is a validation error
                return View();
            }
            
        }
        [HttpGet]
        public ViewResult RetailersForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RetailersForm(Retailers retailers)
        {
            if (ModelState.IsValid)
            {
                return View("RetailersThanks", retailers);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
        [HttpGet]
        public ViewResult GoodsForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult GoodsForm(Goods goods)
        {
            if (ModelState.IsValid)
            {
                return View("GoodsThanks", goods);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
        [HttpGet]
        public ViewResult LogisticsForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult LogisticsForm(Logistics logistics)
        {
            if (ModelState.IsValid)
            {
                return View("LogisticsThanks", logistics);
            }
            else
            {
                //there is a validation error
                return View();
            }
        }
    }
}