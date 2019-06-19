using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wallet.Data;
using Wallet.Services.Core;
using Wallet.Services.GraphQL;

namespace Wallet.Services.Extensions
{
    public static class StartUpConfiguration
    {
        public static void ConfigureDBConnection(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<WalletContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        public static void ConfigureGraphQL(this IServiceCollection services)
        {
            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddScoped<AppSchema>();
            services.AddGraphQL(o => { o.ExposeExceptions = false; })
                .AddGraphTypes(ServiceLifetime.Scoped)
                .AddDataLoader();
        }

        public static void UseGraphQL(this IApplicationBuilder app)
        {
            app.UseGraphQL<AppSchema>();
            app.UseGraphQLPlayground(options: new GraphQLPlaygroundOptions());
        }

        public static void ConfigureDI(this IServiceCollection services)
        {
            services.AddScoped(typeof(IEntityService<>), typeof(EntityService<>));
        }
    }
}