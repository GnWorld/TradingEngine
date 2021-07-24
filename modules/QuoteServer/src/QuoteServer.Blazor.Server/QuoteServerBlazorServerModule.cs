using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace QuoteServer.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(QuoteServerBlazorModule)
        )]
    public class QuoteServerBlazorServerModule : AbpModule
    {
        
    }
}