using System.Collections.Generic;
using BO;

namespace BL.Common
{
    public interface IBlCommon
    {
        List<Unit> GetUnits();
        List<Client> GetNetByUnit(int unitId);
        List<Client> GetClientByNetAndUnit(int netId, int unitId);
        List<string> GetWorkTypes(int unitId, int netId, int clientId);

        List<Client> GetGeparmentByClient(int clientId);
    }
}
