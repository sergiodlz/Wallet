namespace Wallet.Services.Core
{
    public interface IUserManagementService
    {
        bool IsValidUser(string username, string password);
    }
}