using System.Collections.Generic;
using BO;
using DAL.Models;

namespace DAL.Common
{
    public interface IDalCommon
    {
        List<Unit> GetUnits();
        List<Nets> GetNetByUnit(List<int> unitId);
        List<Client> GetClientByNetAndUnit(List<int> netId, List<int> unitId);
        List<string> GetWorkTypes(List<int> unitId, List<int> netId, List<int> clientId);
        List<Department> GetGeparmentByClient(List<int> clientId);
        Result<bool> SaveTemplate(ISmsTemplates template);
        /// <summary>
        /// Загрузить шаблон по умолчанию
        /// </summary>
        /// <param name="eventType">тип события для загружаемого события</param>
        /// <returns></returns>
        Result<string> LoadDefaultTemplate(string eventType);
    }
}
