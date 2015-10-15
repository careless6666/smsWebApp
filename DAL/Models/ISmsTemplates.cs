using System.Collections.Generic;
using BO;

namespace DAL.Models
{
    public interface ISmsTemplates
    {
        /// <summary>
        /// Список условий для отправки
        /// </summary>
        IEnumerable<SmsSendConditions> SmsSendConditionses { get; set; }

        /// <summary>
        /// Список параметров шаблона, клиент, сеть, подразделение и т.д.
        /// </summary>
        IEnumerable<SmsTemplatesParams> SmsTemplatesParamses { get; set; }

        string GetVarName(string name);
        string GetVarKeyCharName(string keyChar);

        SmsEvents Event { get; set; }
        bool IsSend { get; set; }
        string Name { get; set; }
        string Message { get; set; }
        bool IsNeedTranslit { get; set; }
        bool IsDefault { get; set; }
        User User { get; set; }
    }
}
