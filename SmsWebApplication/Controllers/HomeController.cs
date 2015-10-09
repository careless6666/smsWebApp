using System;
using System.Linq;
using System.Web.Mvc;
using SmsWebApplication.Models;

namespace SmsWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private BL.Common.IBlCommon _blCommon;
        public HomeController(BL.Common.IBlCommon blCommon)
        {
            _blCommon = blCommon;
        }

        public ActionResult Index()
        {
            var model = new ModelsList
            {
                AddToOrderViewModel = new AddToOrderViewModel
                {
                    Units = _blCommon.GetUnits(),
                    TimeStart = DateTime.UtcNow.ToString("HH:mm"),
                    TimeEnd = DateTime.UtcNow.ToString("HH:mm")
                }
            };
            return View(model);
        }

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

        public ActionResult AddToOrder() {
            return View();
        }
    }
}