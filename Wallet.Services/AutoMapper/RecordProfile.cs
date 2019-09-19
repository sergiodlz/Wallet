using AutoMapper;
using Wallet.Data.Entities;
using Wallet.Services.ViewModels;

namespace Wallet.Services.AutoMapper
{
    public class RecordProfile : Profile
    {
        public RecordProfile()
        {
            CreateMap<Record, RecordVM>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.Name))
                .ForMember(dest => dest.SubCategory, opt => opt.MapFrom(src => src.SubCategory.Name))
                .ForMember(dest => dest.Account, opt => opt.MapFrom(src => src.Account.Name));

            CreateMap<RecordVM, Record>()
                .ForMember(dest => dest.Type, opt => opt.Ignore())
                .ForMember(dest => dest.SubCategory, opt => opt.Ignore())
                .ForMember(dest => dest.Account, opt => opt.Ignore());
        }
    }
}