using System.Collections.Generic;

namespace DAL.Models
{
    public class AddOrderSmsTemplate : ISmsTemplates
    {
        public IEnumerable<SmsSendConditions> SmsSendConditionses { get; set; }
        public IEnumerable<SmsTemplatesParams> SmsTemplatesParamses { get; set; }
        public SmsEvents Event { get; set; }
        public bool IsSend { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public bool IsNeedTranslit { get; set; }
        public bool IsDefault { get; set; }

        public string GetVarName(string name)
        {
            switch (name)
            {
                case "<%Дата начала%>":
                    return "<%startdate%>";
                case "<%Дата окончания%>":
                    return "<%enddate%>";
                case "<%Время начала%>":
                    return "<%starttime%>";
                case "<%Время окончания%>":
                    return "<%endtime%>";
                case "<%Клиент%>":
                    return "<%client%>";
                case "<%Тип работы%>":
                    return "<%worktype%>";
                case "<%Отдел%>":
                    return "<%department%>";
                case "<%Адрес%>":
                    return "<%address%>";
            }
            return name;
        }

        public string GetVarKeyCharName(string keyChar)
        {
            switch (keyChar)
            {
                case "<%startdate%>":
                case "<%Дата начала%>":
                    return KeyCharVariables.StartDate.ToString();
                case "<%enddate%>":
                case "<%Дата окончания%>":
                    return KeyCharVariables.EndDate.ToString();
                case "<%starttime%>":
                case "<%Время начала%>":
                    return KeyCharVariables.StartTime.ToString();
                case "<%endtime%>":
                case "<%Время окончания%>":
                    return KeyCharVariables.EndTime.ToString();
                case "<%client%>":
                case "<%Клиент%>":
                    return KeyCharVariables.Client.ToString();
                case "<%worktype%>":
                case "<%Тип работы%>":
                    return KeyCharVariables.WorkType.ToString();
                case "<%department%>":
                case "<%Отдел%>":
                    return KeyCharVariables.Department.ToString();
                case "<%address%>":
                case "<%Адрес%>":
                    return KeyCharVariables.Address.ToString();
            }
            return keyChar;
        }

        public static string[] Variables = { "<%Дата начала%>", "<%Дата окончания%>", "<%Время начала%>", "<%Время окончания%>", "<%Клиент%>", "<%Тип работы%>", "<%Отдел%>", "<%Адрес%>" };

    }

    public enum KeyCharVariables
    {
        StartDate,
        EndDate,
        StartTime,
        EndTime,
        Client,
        WorkType,
        Department,
        Address,
        Unit,
        Net
    }
}
