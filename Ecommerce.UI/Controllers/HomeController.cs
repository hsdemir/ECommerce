using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ecommerce.CORE.Repository;

namespace Ecommerce.UI.Controllers
{
    public class HomeController : Controller
    {
        private IPayment _payment;

        public HomeController(IPayment payment)
        {
            _payment = payment;
        }

        public ActionResult Index()
        {
           // string process = _payment.DoPayment();

           //ViewData["sonuc"] = process;

            return View();
        }

    }
}
