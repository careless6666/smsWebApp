using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BinaryAnalysis.UnidecodeSharp;
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
            var units = _blCommon.GetUnits();
            var nets = _blCommon.GetNetByUnit(null);
            
            var model = new ModelsList
            {
                AddToOrderViewModel = new AddToOrderViewModel
                {
                    Units = units,
                    Networks = nets,
                    Clients = new List<Client>(),
                    WorkTypes = new List<string>(),
                    Deparment = new List<Department>(),
                    DateStart = DateTime.UtcNow.Date.ToString("dd.MM.yyyy"),
                    DateEnd = DateTime.UtcNow.AddDays(7).Date.ToString("dd.MM.yyyy"),
                    TimeStart = "",// DateTime.UtcNow.ToString("HH:mm"),
                    TimeEnd = "", //DateTime.UtcNow.ToString("HH:mm"),
                    Message = "",
                    EnableTranslite = false,
                    DefaultTemplate = "Вы добавлены на смену с <%Время начала%> до <%Время окончания%> Объект: <%Клиент%> Тип работ: <%Тип работы%> Адрес: <%Адрес%> PRALUDI"
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
    }
}