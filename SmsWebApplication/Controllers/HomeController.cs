using System;
using System.Collections.Generic;
using System.Web.Mvc;
using BO;
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
            var units = _blCommon.GetUnits();
            units.Insert(0, new Unit { Id = -1, Name = "Все" });
            var nets = _blCommon.GetNetByUnit(-1);
            nets.Insert(0, new Nets{Id = -1, Name = "Все"});
            var clients = _blCommon.GetClientByNetAndUnit(-1, -1);
            clients.Insert(0, new Client {Id = -1, Name = "Все"});
            var model = new ModelsList
            {
                AddToOrderViewModel = new AddToOrderViewModel
                {
                    Units = units,
                    Networks = nets,
                    Clients = clients,
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

        public ActionResult GetNets(int unitId)
        {
            var nets =_blCommon.GetNetByUnit(unitId);
            return Json(nets.ToArray(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetClients(int netId, int unitId)
        {
            var nets = _blCommon.GetClientByNetAndUnit(netId, unitId);
            return Json(nets.ToArray(), JsonRequestBehavior.AllowGet);
        }
    }
}