using Wallet.Services.Core;

namespace Wallet.Services
{
    public class UserManagementService : IUserManagementService
    {
        public bool IsValidUser(string userName, string password)
        {
            return true;
        }
    }
}