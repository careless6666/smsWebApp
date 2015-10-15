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
        Result SaveTemplate(ISmsTemplates template);
    }
}
