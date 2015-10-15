using System.Collections.Generic;

namespace BO
{
    public class AddToOrderModel
    {
        public List<int> Units { get; set; }
        public List<int> Networks { get; set; }
        public List<int> Clients { get; set; }
        public List<string> WorkTypes { get; set; }
        public List<int> Deparment { get; set; }
        public bool IsDefaultTemplate { get; set; }
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public string Message { get; set; }
        public bool SendSms { get; set; }
        public bool EnableTranslite { get; set; }
    }
}
