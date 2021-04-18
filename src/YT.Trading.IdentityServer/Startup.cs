using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace YT.Trading
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<TradingIdentityServerModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
