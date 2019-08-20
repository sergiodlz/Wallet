using Wallet.Services.ViewModels;

namespace Wallet.Services.Core
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(TokenRequest request, out string token);
    }
}