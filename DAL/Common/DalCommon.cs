using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using BO;
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

        public void SaveTemplate(ISmsTemplates template)
        {
            using (var context = new BdpEntities())
            {
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback();
                    }
                }
            }
        }

        void SaveoOtVariables(ISmsTemplates template, BdpEntities context)
        {
            var smsEvent =
                context.OPT_SMS_EVENTS.Single(x => x.KEY_CHAR_VALUE.Equals(template.Event.EventType.ToString()));

            foreach (var smsVariablese in template.Event.Variables)
            {
                //context.OPT_SMS_E
                //context.OPT_SMS_VARIABLES.Add(new OPT_SMS_VARIABLES
                //{
                //    NAME = smsVariablese.Name,
                //    KEY_CHAR_VALUE = smsVariablese.KeyCharName
                //});
            }
        }
    }
}
