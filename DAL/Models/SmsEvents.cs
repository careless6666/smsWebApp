using System.Collections.Generic;

namespace DAL.Models
{
    public class SmsEvents
    {
        public IEnumerable<SmsVariables> Variables { get; set; }
        public SmsEventTypes EventType { get; set; }
    }
}
