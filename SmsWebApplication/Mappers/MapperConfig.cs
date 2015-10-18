using AutoMapper;
using BO;
using SmsWebApplication.Models;

namespace SmsWebApplication.Mappers
{
    public class MapperConfig
    {
        public static void RegisterMappings()
        {
            MapAddToOrderViewModelAndAddToOrderBoModel.Map();
        }

        class MapAddToOrderViewModelAndAddToOrderBoModel
        {
            public static void Map()
            {
                Mapper.CreateMap<AddToOrderViewModel, AddToOrderModel>()
                    .ForMember(dest => dest.Message, src => src.MapFrom(x=>x.Message))
                    .ForMember(dest => dest.Clients, src => src.MapFrom(x => x.Clients))
                    .ForMember(dest => dest.DateEnd, src => src.MapFrom(x => x.DateEnd))
                    .ForMember(dest => dest.DateStart, src => src.MapFrom(x => x.DateStart))
                    .ForMember(dest => dest.Deparment, src => src.MapFrom(x => x.Deparment))
                    .ForMember(dest => dest.EnableTranslite, src => src.MapFrom(x => x.EnableTranslite))
                    .ForMember(dest => dest.IsDefaultTemplate, src => src.MapFrom(x => x.DefaultTemplate))
                    .ForMember(dest => dest.Networks, src => src.MapFrom(x => x.Networks))
                    .ForMember(dest => dest.SendSms, src => src.MapFrom(x => x.IsSendSms))
                    .ForMember(dest => dest.TimeEnd, src => src.MapFrom(x => x.TimeEnd))
                    .ForMember(dest => dest.TimeStart, src => src.MapFrom(x => x.TimeStart))
                    .ForMember(dest => dest.Units, src => src.MapFrom(x => x.Units))
                    .ForMember(dest => dest.WorkTypes, src => src.MapFrom(x => x.WorkTypes))
                    ;

                Mapper.CreateMap<AddToOrderModel, AddToOrderViewModel>()
                    .ForMember(dest => dest.Message, src => src.MapFrom(x => x.Message))
                    .ForMember(dest => dest.Clients, src => src.MapFrom(x => x.Clients))
                    .ForMember(dest => dest.DateEnd, src => src.MapFrom(x => x.DateEnd))
                    .ForMember(dest => dest.DateStart, src => src.MapFrom(x => x.DateStart))
                    .ForMember(dest => dest.Deparment, src => src.MapFrom(x => x.Deparment))
                    .ForMember(dest => dest.EnableTranslite, src => src.MapFrom(x => x.EnableTranslite))
                    .ForMember(dest => dest.DefaultTemplate, src => src.MapFrom(x => x.IsDefaultTemplate))
                    .ForMember(dest => dest.Networks, src => src.MapFrom(x => x.Networks))
                    .ForMember(dest => dest.IsSendSms, src => src.MapFrom(x => x.SendSms))
                    .ForMember(dest => dest.TimeEnd, src => src.MapFrom(x => x.TimeEnd))
                    .ForMember(dest => dest.TimeStart, src => src.MapFrom(x => x.TimeStart))
                    .ForMember(dest => dest.Units, src => src.MapFrom(x => x.Units))
                    .ForMember(dest => dest.WorkTypes, src => src.MapFrom(x => x.WorkTypes))
                    ;
            }
        }
    }
}