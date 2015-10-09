using System;
using System.Collections.Generic;
using System.Linq;
using BO;

namespace DAL.Common 
{
    public class DalCommon : IDalCommon
    {
        public List<Unit> GetUnits()
        {
            using (var db = new BdpEntities())
            {
                return (from unit in db.SC_UNIT select new Unit {Id = (int)unit.UN_ID, Name = unit.UN_NAME}).ToList();
            }
        }

        public List<Client> GetNetByUnit(int unitId)
        {
            throw new NotImplementedException();
        }

        public List<Client> GetClientByNetAndUnit(int netId, int unitId)
        {
            throw new NotImplementedException();
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
