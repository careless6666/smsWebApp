using System.Collections.Generic;
using System.Web.Mvc;
using BO;

namespace SmsWebApplication.Models
{
    public class AddToOrderViewModel
    {
        public List<Unit> Units { get; set; }
        public Unit SelectedUnitAddToOrder { get; set; }
        public List<Nets> Networks { get; set; }
        public Nets SelectedNetworkAddToOrder { get; set; }
        public List<Client> Clients { get; set; }
        public Client SelectedClientAddToOrder { get; set; }
        public List<string> WorkTypes { get; set; }
        public string SelectedWorkTypesAddToOrder { get; set; }
        public List<Department> Deparment { get; set; }
        public string SelectedDepartmentAddToOrder { get; set; }
        public string DefaultTemplate { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string Message { get; set; }
        public bool IsSendSms => false;
        public bool EnableTranslite { get; set; }
    }
}