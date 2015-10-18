using System.Collections.Generic;
using BO;

namespace BL.Common
{
    public interface IBlCommon
    {
        List<Unit> GetUnits();
        List<Nets> GetNetByUnit(List<int> unitId);
        List<Client> GetClientByNetAndUnit(List<int> netId, List<int> unitId);
        List<string> GetWorkTypes(List<int> unitId, List<int> netId, List<int> clientId);

        List<Department> GetGeparmentByClient(List<int> clientIds);

        Result<bool> SaveSmsTemplate(AddToOrderModel addToOrderModel);

        Result<string> LoadDefaultTemplate(string eventType);
    }
}
