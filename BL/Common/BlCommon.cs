﻿using System.Collections.Generic;
using BO;

namespace BL.Common
{
    public class BlCommon : IBlCommon
    {
        private DAL.Common.IDalCommon _dalDalCommon;
        public BlCommon(DAL.Common.IDalCommon dalDalCommon)
        {
            _dalDalCommon = dalDalCommon;
        }

        public List<Unit> GetUnits()
        {
            return _dalDalCommon.GetUnits();
        }

        public List<Client> GetNetByUnit(int unitId)
        {
            throw new System.NotImplementedException();
        }

        public List<Client> GetClientByNetAndUnit(int netId, int unitId)
        {
            throw new System.NotImplementedException();
        }

        public List<string> GetWorkTypes(int unitId, int netId, int clientId)
        {
            throw new System.NotImplementedException();
        }

        public List<Client> GetGeparmentByClient(int clientId)
        {
            throw new System.NotImplementedException();
        }
    }
}
