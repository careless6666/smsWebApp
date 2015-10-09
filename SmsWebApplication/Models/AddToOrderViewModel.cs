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
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string Message { get; set; }
        public bool SendSms { get; set; }
        public bool EnableTranslate { get; set; }
    }
}