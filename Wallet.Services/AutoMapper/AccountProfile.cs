using AutoMapper;
using Wallet.Data.Entities;
using Wallet.Services.ViewModels;

namespace Wallet.Services.AutoMapper
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<Account, AccountVM>()
                .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.Name));

            CreateMap<AccountCreateVM, Account>()
                .ForMember(dest => dest.Type, opt => opt.Ignore());
        }
    }
}