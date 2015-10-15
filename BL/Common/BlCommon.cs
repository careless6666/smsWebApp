using System.Collections.Generic;
using System.Linq;
using BO;
using DAL.Models;

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

        public List<Nets> GetNetByUnit(List<int> unitId)
        {
            return _dalDalCommon.GetNetByUnit(unitId);
        }

        public List<Client> GetClientByNetAndUnit(List<int> netId, List<int> unitId)
        {
            return _dalDalCommon.GetClientByNetAndUnit(netId, unitId);
        }

        public List<string> GetWorkTypes(List<int> unitId, List<int> netId, List<int> clientId)
        {
            return _dalDalCommon.GetWorkTypes(unitId, netId, clientId);
        }

        public List<Department> GetGeparmentByClient(List<int> clientIds)
        {
            return _dalDalCommon.GetGeparmentByClient(clientIds);
        }

        /// <summary>
        /// Сохраним шаблон для добавления на заказ
        /// </summary>
        /// <param name="addToOrderModel">модель добавления на заказ</param>
        public void SaveSmsTemplate(AddToOrderModel addToOrderModel)
        {
            var ao = new AddToOrderLogic();
            ao.SaveTemplate(addToOrderModel);
        }

        
    }
}
