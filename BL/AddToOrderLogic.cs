using System.Collections.Generic;
using System.Linq;
using System.Web;
using BO;
using DAL.Common;
using DAL.Models;

namespace BL
{
    public class AddToOrderLogic
    {
        private IDalCommon _dalCommon;

        public AddToOrderLogic(IDalCommon dalCommon)
        {
            _dalCommon = dalCommon;
        }

        /// <summary>
        /// Сохраним шаблон для добавления на заказ
        /// </summary>
        /// <param name="addToOrderModel"></param>
        public Result<bool> SaveTemplate(AddToOrderModel addToOrderModel)
        {
            ISmsTemplates smsTemplate = new AddOrderSmsTemplate();

            smsTemplate.IsDefault = addToOrderModel.IsDefaultTemplate;
            smsTemplate.IsNeedTranslit = addToOrderModel.EnableTranslite;
            smsTemplate.Message = addToOrderModel.Message;
            smsTemplate.IsSend = addToOrderModel.SendSms;

            //переменные сообщения
            var vars = (from variable in AddOrderSmsTemplate.Variables
                        where addToOrderModel.Message.Contains(variable)
                        select new SmsVariables
                        {
                            Name = smsTemplate.GetVarName(variable),
                            KeyCharName = smsTemplate.GetVarKeyCharName(variable)
                        }).ToList();

            //событие сообщения
            smsTemplate.Event = new SmsEvents
            {
                EventType = SmsEventTypes.AddToOrder,
                Variables = vars
            };

            //условия для отправки сообщений
            var sendConditions = new List<SmsSendConditions>();

            //дата начала заказа с 
            sendConditions.AddRange(addSendConditions(addToOrderModel.DateStart, ConditionTypes.GreaterThanOrEquals, KeyCharVariables.StartDate));

            //дата начала заказа по
            sendConditions.AddRange(addSendConditions(addToOrderModel.DateEnd, ConditionTypes.LessThanOrEquals, KeyCharVariables.EndDate));

            //время начала заказа с
            sendConditions.AddRange(addSendConditions(addToOrderModel.TimeStart, ConditionTypes.GreaterThanOrEquals, KeyCharVariables.StartTime));

            //время начала заказа по
            sendConditions.AddRange(addSendConditions(addToOrderModel.TimeEnd, ConditionTypes.LessThanOrEquals, KeyCharVariables.EndTime));

            smsTemplate.SmsSendConditionses = sendConditions;

            //параметры шаблона
            var smsParams = new List<SmsTemplatesParams>();

            if (!addToOrderModel.IsDefaultTemplate)
            {
                //подразделения
                smsParams.AddRange(addTemplateParams(addToOrderModel.Units, ConditionTypes.Equals, KeyCharVariables.Unit));

                //сети
                smsParams.AddRange(addTemplateParams(addToOrderModel.Networks, ConditionTypes.Equals,
                    KeyCharVariables.Net));

                //клиенты
                smsParams.AddRange(addTemplateParams(addToOrderModel.Clients, ConditionTypes.Equals,
                    KeyCharVariables.Client));

                //типы работ
                smsParams.AddRange(addTemplateParams(addToOrderModel.WorkTypes, ConditionTypes.Equals,
                    KeyCharVariables.WorkType));

                //отделы
                smsParams.AddRange(addTemplateParams(addToOrderModel.Deparment, ConditionTypes.Equals,
                    KeyCharVariables.Department));
            }
            else
            {
                var list = new List<int>();
                //подразделения
                smsParams.AddRange(addTemplateParams(list, ConditionTypes.Equals, KeyCharVariables.Unit));

                //сети
                smsParams.AddRange(addTemplateParams(list, ConditionTypes.Equals, KeyCharVariables.Net));

                //клиенты
                smsParams.AddRange(addTemplateParams(list, ConditionTypes.Equals, KeyCharVariables.Client));

                //типы работ
                smsParams.AddRange(addTemplateParams(list, ConditionTypes.Equals, KeyCharVariables.WorkType));

                //отделы
                smsParams.AddRange(addTemplateParams(list, ConditionTypes.Equals, KeyCharVariables.Department));
            }

            smsTemplate.SmsTemplatesParamses = smsParams;
            
            smsTemplate.User = new User { LadpName = HttpContext.Current.User.Identity.Name };

            return _dalCommon.SaveTemplate(smsTemplate);
        }

        IEnumerable<SmsTemplatesParams> addTemplateParams<T>(List<T> itemslist, ConditionTypes condition, KeyCharVariables field)
        {
            var smsParams = new List<SmsTemplatesParams>();

            if (itemslist == null || !itemslist.Any())
            {
                smsParams.Add(new SmsTemplatesParams
                {
                    Value = "-1",
                    TypeCondition = condition,
                    Field = field.ToString()
                });
            }
            else
            {
                itemslist.ForEach(x =>
                {
                    smsParams.Add(new SmsTemplatesParams
                    {
                        Value = x.ToString(),
                        TypeCondition = condition,
                        Field = field.ToString()
                    });
                });
            }

            return smsParams;
        }

        IEnumerable<SmsSendConditions> addSendConditions(string param, ConditionTypes condition, KeyCharVariables kcv)
        {
            var smsConditions = new List<SmsSendConditions>();

            if (!string.IsNullOrEmpty(param))
            {
                smsConditions.Add(new SmsSendConditions
                {
                    TypeCondition = condition,
                    Value = param,
                    Parameter = kcv.ToString()
                });
            }

            return smsConditions;
        }
    }
}
