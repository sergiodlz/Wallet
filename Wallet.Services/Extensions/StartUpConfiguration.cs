using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wallet.Data;

namespace Wallet.Services.Extensions
{
    public static class StartUpConfiguration
    {
        public static void ConfigureDBConnection(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<WalletContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}