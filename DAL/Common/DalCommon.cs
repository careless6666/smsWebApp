using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using BO;
using DAL.DbClasses;
using DAL.Models;

namespace DAL.Common 
{
    public class DalCommon : IDalCommon
    {
        public List<Unit> GetUnits()
        {
            using (var db = new BdpEntities())
            {
                return (from unit in db.SC_UNIT select new Unit {Id = (int)unit.UN_ID, Name = unit.UN_NAME}).OrderBy(x=>x.Name).ToList();
            }
        }

        public List<Nets> GetNetByUnit(List<int> unitId)
        {
            using (var db = new BdpEntities())
            {
                if(unitId != null && unitId.Count > 0)
                return (from nets in db.CL_NETS
                        from client in nets.CL_CLIENTS
                        where unitId.Contains((int)client.UN_ID) 
                        select new Nets { Id = (int)nets.NT_ID, Name = nets.NT_NAME}).Distinct().OrderBy(x=>x.Name).ToList();

                return (from nets in db.CL_NETS
                        from client in nets.CL_CLIENTS
                        select new Nets { Id = (int)nets.NT_ID, Name = nets.NT_NAME }).Distinct().OrderBy(x=>x.Name).ToList();
            }
        }

        public List<Client> GetClientByNetAndUnit(List<int> netId = null, List<int> unitId = null)
        {
            using (var db = new BdpEntities())
            {
                var clients = from client in db.CL_CLIENTS
                    select client;

                var queryableData = clients;

                if (netId != null && netId.Any())
                    queryableData = queryableData.Where(x => netId.Contains((int) x.NT_ID));
                

                if (unitId != null && unitId.Any())
                    queryableData = queryableData.Where(x => unitId.Contains((int)x.UN_ID));

                if(netId == null && unitId == null || !netId.Any() && !unitId.Any())
                    return new List<Client>();
                
                return (from client in queryableData select new Client {Id = (int)client.CL_ID, Name = client.CL_NAME}).OrderBy(x=>x.Name).ToList();
            }
        }

        public List<string> GetWorkTypes(List<int> unitId, List<int> netId, List<int> clientId)
        {
            using (var db = new BdpEntities())
            {
                var query = (from ccwt in db.CL_CONTRACT_WORK_TYPE
                    join cjn in db.CL_JURI_NETS on ccwt.CJNN_ID equals cjn.CJNN_ID
                    join cci in db.CL_CONTRACT_ITEM on ccwt.CCWT_ID equals cci.CCWT_ID
                    join cr in db.CL_RATE on cci.CCI_ID equals cr.CCI_ID
                    join cc in db.CL_CLIENTS on cr.CL_ID equals cc.CL_ID
                            where !cr.IS_MISTAKEN && cr.CR_DATE_TO >= DateTime.UtcNow
                            select new { NetworkId = (int)cjn.NT_ID, ClientId = (int)cc.CL_ID, UnitId = (int)cc.UN_ID, WorkTypeName = ccwt.WT_NAME})
                            .Distinct();

                
                if (clientId != null && clientId.Any())
                    query = query.Where(x=> clientId.Contains(x.ClientId));

                if (netId != null && netId.Any())
                    query = query.Where(x => netId.Contains(x.NetworkId));

                if (unitId != null && unitId.Any())
                    query = query.Where(x => unitId.Contains(x.UnitId));

                if(unitId == null && netId == null && clientId == null || !netId.Any() && !unitId.Any() && !clientId.Any())
                    return new List<string>();

                return (from wt in query select wt.WorkTypeName).OrderBy(q=>q).Distinct().ToList();
            }
        }

        public List<Department> GetGeparmentByClient(List<int> clientId)
        {
            using (var db = new BdpEntities())
            {
                if(clientId == null || !clientId.Any())
                    return new List<Department>();

                return (from cnd in db.CL_CLIENTS_NETS_DEPARTEMNTS
                    where clientId.Contains((int) cnd.CL_ID)
                    select new Department
                    {
                        Id = (int) cnd.CL_NETS_DEPARTMENTS.CL_DEPARTMENTS.DEP_ID,
                        Name = cnd.CL_NETS_DEPARTMENTS.CL_DEPARTMENTS.DEP_NAME
                    }).ToList();
            }
        }

        public Result<bool> SaveTemplate(ISmsTemplates template)
        {
            var res = new Result<bool>();
            using (var context = new BdpEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var existTemplate = CheckExistTemplate(template.SmsTemplatesParamses, context, template.Event.EventType, template.IsDefault);
                        if (existTemplate != null)
                        {
                            //условия отправки шаблона
                            existTemplate.SMS_SEND_CONDITIONS_PARAMS.ToList().ForEach(x=> context.SMS_SEND_CONDITIONS_PARAMS.Remove(x));
                            existTemplate = AddSendConditionParams(existTemplate, template.SmsSendConditionses, context);

                            existTemplate.IS_SEND = template.IsSend;
                            existTemplate.MESSAGE = template.Message;
                            existTemplate.IS_NEED_TRANSLIT = template.IsNeedTranslit;
                            existTemplate.IS_DEFAULT = template.IsDefault;

                            //запись в историю
                            existTemplate.SMS_TEMPLATES_HISTORY.Add(new SMS_TEMPLATES_HISTORY
                            {
                                EDIT_DATE = DateTime.UtcNow,
                                US_ID = context.SC_USERS.Single(x => x.SCU_LDAP_ACCOUNT.Equals(template.User.LadpName)).US_ID,
                            });
                        }
                        else
                        {
                            var templ = new SMS_TEMPLATES();
                            //условия отправки шаблона
                            templ = AddSendConditionParams(templ, template.SmsSendConditionses, context);
                            //параметры шаблона
                            templ = AddSmsTemplatesParams(templ, template.SmsTemplatesParamses, context);
                            //событие шаблона
                            templ.OPT_SMS_EVENTS =
                                context.OPT_SMS_EVENTS.Single(
                                    x => x.KEY_CHAR_VALUE.Equals(template.Event.EventType.ToString()));

                            templ.IS_SEND = template.IsSend;
                            templ.MESSAGE = template.Message;
                            templ.IS_NEED_TRANSLIT = template.IsNeedTranslit;
                            templ.IS_DEFAULT = template.IsDefault;

                            //запись в историю
                            templ.SMS_TEMPLATES_HISTORY.Add(new SMS_TEMPLATES_HISTORY
                            {
                                EDIT_DATE = DateTime.UtcNow,
                                US_ID = context.SC_USERS.Single(x => x.SCU_LDAP_ACCOUNT.Equals(template.User.LadpName)).US_ID,
                            });

                            context.SMS_TEMPLATES.Add(templ);
                        }
                        
                        context.SaveChanges();
                        dbContextTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        res.ResultOperation = false;
                        res.ErrorMessage = ex.Message;
                        res.Exception = res.Exception;
                    }
                    return res;
                }
            }
        }

        public Result<string> LoadDefaultTemplate(string eventType)
        {
            var res= new Result<string>();
            try
            {
                using (var context = new BdpEntities())
                {
                    res.ResultObject =
                        context.SMS_TEMPLATES.Single(
                            x => x.IS_DEFAULT && x.OPT_SMS_EVENTS.KEY_CHAR_VALUE.Equals(eventType)).MESSAGE;
                }
            }
            catch (Exception ex)
            {
                res.ResultOperation = false;
                res.ErrorMessage = ex.Message;
                res.Exception = ex;
            }
            return res;
        }

        /// <summary>
        /// Условия отправки шаблона
        /// </summary>
        /// <param name="templ">шаблон</param>
        /// <param name="smsSendConditionses">список условий</param>
        /// <param name="context"></param>
        /// <returns></returns>
        SMS_TEMPLATES AddSendConditionParams(SMS_TEMPLATES templ, IEnumerable<SmsSendConditions> smsSendConditionses, BdpEntities context)
        {
            foreach (var smsSendConditionse in smsSendConditionses)
            {
                templ.SMS_SEND_CONDITIONS_PARAMS.Add(new SMS_SEND_CONDITIONS_PARAMS
                {
                    VALUE = smsSendConditionse.Value,
                    ID_SMS_SEND_CONDITIONS = context.SMS_SEND_CONDITIONS.Single(x=>x.KEY_CHAR_VALUE.Equals(smsSendConditionse.TypeCondition.ToString())).ID,
                    ID_TYPE = context.SMS_SEND_CONDITIONS_TYPES.Single(x=>x.KEY_CHAR_VALUE.Equals(smsSendConditionse.Parameter)).ID
                });
            }
            return templ;
        }

        /// <summary>
        /// Параметры шаблона
        /// </summary>
        /// <param name="templ"></param>
        /// <param name="smsTemplatesParamses"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        SMS_TEMPLATES AddSmsTemplatesParams(SMS_TEMPLATES templ, IEnumerable<SmsTemplatesParams> smsTemplatesParamses, BdpEntities context)
        {
            foreach (var smsTemplatesParamse in smsTemplatesParamses)
            {
                templ.SMS_TEMPLATES_PARAMS.Add(new SMS_TEMPLATES_PARAMS
                {
                    VALUE = smsTemplatesParamse.Value,
                    ID_CONDITION = context.SYS_CONDITIONS.Single(x=>x.KEY_CHAR_VALUE.Equals(smsTemplatesParamse.TypeCondition.ToString())).ID,
                    ID_FIELD = context.SYS_FIELDS.Single(x=>x.KEY_CHAR_VALUE.Equals(smsTemplatesParamse.Field)).ID
                });
            }
            return templ;
        }

        SMS_TEMPLATES CheckExistTemplate(IEnumerable<SmsTemplatesParams> smsTemplatesParamses, BdpEntities context, SmsEventTypes eventType, bool isDefault)
        {
            var count = smsTemplatesParamses.Count();
            var templates = context.SMS_TEMPLATES.Where(x=>x.SMS_TEMPLATES_PARAMS.Count == count &&
                                                                                                 x.IS_DEFAULT.Equals(isDefault) &&
                                                                                                 x.OPT_SMS_EVENTS.KEY_CHAR_VALUE.Equals(eventType.ToString())
                                                            );

            foreach (var smsTemplatesParamse in smsTemplatesParamses)
            {
                templates = 
                    templates.Where(
                       x => x.SMS_TEMPLATES_PARAMS.Any(z => z.VALUE.Equals(smsTemplatesParamse.Value) &&
                        z.SYS_FIELDS.KEY_CHAR_VALUE.Equals(smsTemplatesParamse.Field) && 
                         z.SYS_CONDITIONS.KEY_CHAR_VALUE.Equals(smsTemplatesParamse.TypeCondition.ToString())));
            }

            return templates.FirstOrDefault();
        }
    }
}
