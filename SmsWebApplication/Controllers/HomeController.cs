using System;
using System.Linq;
using System.Web.Helpers;
using System.Web.Mvc;
using BO;
using Newtonsoft.Json;
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
            var pm = new PrepareModel();
            var model = new ModelsList
            {
		//AddToOrderViewModel = pm.GetAddToOrderModel()
		AddToOrderViewModel = new AddToOrderViewModel
		{
		   Clients = new List<Client>(),
		   Deparment = new List<Department>(),
		   Networks = new List<Nets>(),
		   Units = new List<Unit>,
		   WorkTypes = new List<string>
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

        public ActionResult GetNets(string unitId)
        {
            var list = JsonConvert.DeserializeObject<int[]>(unitId);
            var nets =_blCommon.GetNetByUnit(list.ToList());
            return Json(nets.ToArray(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetClients(string netId, string unitId)
        {
            var units = JsonConvert.DeserializeObject<int[]>(unitId);
            var nets = JsonConvert.DeserializeObject<int[]>(netId);
            var clients = _blCommon.GetClientByNetAndUnit(nets.ToList(), units.ToList());
            return Json(clients.ToArray(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetWorkTypes(string netId, string unitId, string clientId)
        {
            var units = JsonConvert.DeserializeObject<int[]>(unitId);
            var nets = JsonConvert.DeserializeObject<int[]>(netId);
            var clients = JsonConvert.DeserializeObject<int[]>(clientId);
            var clientsRes = _blCommon.GetWorkTypes(units.ToList(), nets.ToList(), clients.ToList());
            return Json(clientsRes.Select(x=> new {Id = x, Name = x}), JsonRequestBehavior.AllowGet);
        }

        public ActionResult GetDepartments(string clientId)
        {
            var clients = JsonConvert.DeserializeObject<int[]>(clientId);
            var deparments = _blCommon.GetGeparmentByClient(clients.ToList());
            return Json(deparments, JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveAddToOrder(AddToOrderModel addToOrderModel)
        {
            return Json(_blCommon.SaveSmsTemplate(addToOrderModel));
        }

        public ActionResult LoadDefaultTemplate(string eventType)
        {
            return Json(_blCommon.LoadDefaultTemplate(eventType));
        }
    }
}
