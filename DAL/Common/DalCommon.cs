using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BO;

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

        public List<Nets> GetNetByUnit(int unitId)
        {
            using (var db = new BdpEntities())
            {
                if(unitId != -1)
                return (from nets in db.CL_NETS
                        from client in nets.CL_CLIENTS
                        where client.UN_ID == unitId
                        select new Nets { Id = (int)nets.NT_ID, Name = nets.NT_NAME}).Distinct().OrderBy(x=>x.Name).ToList();

                return (from nets in db.CL_NETS
                        from client in nets.CL_CLIENTS
                        select new Nets { Id = (int)nets.NT_ID, Name = nets.NT_NAME }).Distinct().OrderBy(x=>x.Name).ToList();
            }
        }

        public List<Client> GetClientByNetAndUnit(int netId, int unitId)
        {
            using (var db = new BdpEntities())
            {
                var clients = from client in db.CL_CLIENTS
                    select client;

                var queryableData = clients;

                var pe = Expression.Parameter(typeof(CL_CLIENTS), "client");

                var left = Expression.Property(pe, clients.ElementType.GetProperty("NT_ID"));
                var right = Expression.Constant((decimal?)netId, typeof(decimal?));
                var netCondition = Expression.Equal(left, right);

                left = Expression.Property(pe, clients.ElementType.GetProperty("UN_ID"));
                right = Expression.Constant((decimal)unitId, typeof(decimal));
                var unitCondition = Expression.Equal(left, right);

                var cleft = Expression.Constant(0, typeof(int));
                var cright = Expression.Constant(0, typeof(int));
                var stubCondition = Expression.Equal(cleft, cright);

                Expression resultCondition = Expression.Empty();

                if (netId != -1 && unitId != -1)
                    resultCondition = Expression.And(netCondition, unitCondition);

                else if (netId == -1 && unitId != -1)
                    resultCondition = unitCondition;

                else if (unitId == -1 && netId != -1)
                    resultCondition = netCondition;

                if (resultCondition.NodeType == ExpressionType.Default)
                    resultCondition = stubCondition;

                var expQuery = Expression.Call(typeof (Queryable), "Where", new[] {clients.ElementType}, clients.Expression,
                                Expression.Lambda<Func<CL_CLIENTS, bool>>(resultCondition, pe));

                var res = (IQueryable<CL_CLIENTS>)queryableData.Provider.CreateQuery(expQuery);
                
                return (from client in res select new Client {Id = (int)client.CL_ID, Name = client.CL_NAME}).OrderBy(x=>x.Name).ToList();
            }
        }

        public List<string> GetWorkTypes(int unitId, int netId, int clientId)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetGeparmentByClient(int clientId)
        {
            throw new NotImplementedException();
        }
    }
}
