using System;
using System.Collections.Generic;
using System.Linq;
using BO;
using DI;
using Newtonsoft.Json.Linq;

namespace SmsWebApplication.Models
{
    public class PrepareModel
    {
        private BL.Common.IBlCommon _blCommon;

        public PrepareModel ()
        {
            var resolver = new DResovler();
            _blCommon = resolver.ResolveByType<BL.Common.IBlCommon>(ResolverModuleType.Web);
        }

        public AddToOrderViewModel GetAddToOrderModel()
        {
            var units = _blCommon.GetUnits();
            var nets = _blCommon.GetNetByUnit(null);

            var addToOrderViewModel = new AddToOrderViewModel
            {
                Units = units,
                Networks = nets,
                Clients = new List<Client>(),
                WorkTypes = new List<string>(),
                Deparment = new List<Department>(),
                DateStart = DateTime.UtcNow.Date.ToString("dd.MM.yyyy"),
                DateEnd = DateTime.UtcNow.AddDays(7).Date.ToString("dd.MM.yyyy"),
                TimeStart = "", // DateTime.UtcNow.ToString("HH:mm"),
                TimeEnd = "", //DateTime.UtcNow.ToString("HH:mm"),
                Message = "",
                EnableTranslite = false,
                DefaultTemplate =
                    "Вы добавлены на смену с <%Время начала%> до <%Время окончания%> Объект: <%Клиент%> Тип работ: <%Тип работы%> Адрес: <%Адрес%> PRALUDI"
            };

            return addToOrderViewModel;
        }

        public AddToOrderModel GetAddToOrderModel(string viewModel)
        {
            dynamic d = JObject.Parse(viewModel);
            var model = new AddToOrderModel
            {
                Units = d.unitId.ToObject<List<int>>(),
                Networks = d.netId.ToObject<List<int>>(),
                Clients = d.clientId.ToObject<List<int>>(),
                Deparment = d.deparment.ToObject<List<int>>(),
                WorkTypes = d.workType.ToObject<List<string>>(),
                Message = d.message.ToObject<string>(),
                //IsDefaultTemplate = d.isDefault.ToObject<bool>(),
                //DateStart = d.dateStart.ToObject<DateTime?>(),


            };
            return model;
        }

    }
}