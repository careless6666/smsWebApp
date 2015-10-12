using System.Collections.Generic;
using BO;

namespace DAL.Common
{
    public interface IDalCommon
    {
        List<Unit> GetUnits();
        List<Nets> GetNetByUnit(int unitId);
        List<Client> GetClientByNetAndUnit(int netId, int unitId);
        List<string> GetWorkTypes(int unitId, int netId, int clientId);

        List<Client> GetGeparmentByClient(int clientId);
    }
}
