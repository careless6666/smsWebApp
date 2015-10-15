namespace DAL.Models
{
    public class SmsSendConditions
    {
        /// <summary>
        /// Тип условия, больше, меньшне, равно и т.д.
        /// </summary>
        public ConditionTypes TypeCondition { get; set; }
        /// <summary>
        /// Значение с которым сравнивается параметр
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Имя параметра вляющего на условия для отправки
        /// </summary>
        public string Parameter { get; set; }
    }
}
