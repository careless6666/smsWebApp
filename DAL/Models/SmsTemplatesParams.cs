namespace DAL.Models
{
    public class SmsTemplatesParams
    {
        public ConditionTypes TypeCondition { get; set; }
        public string Field { get; set; }
        public string Value { get; set; }
    }
}
