using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SmsWebApplication.Models
{
    public class AddToOrderViewModel
    {
        public List<SelectListItem> Units { get; set; }
        public List<SelectListItem> Networks { get; set; }
        public List<SelectListItem> Clients { get; set; }
        public List<SelectListItem> WorkTypes { get; set; }
        public List<SelectListItem> Deparment { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Message { get; set; }
    }
}