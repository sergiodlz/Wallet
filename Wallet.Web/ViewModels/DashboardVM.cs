using System.Collections.Generic;
using Wallet.Services.ViewModels;

namespace Wallet.Web.ViewModels
{
    public class DashboardVM
    {
        public ICollection<AccountVM> Accounts { get; set; }
    }
}