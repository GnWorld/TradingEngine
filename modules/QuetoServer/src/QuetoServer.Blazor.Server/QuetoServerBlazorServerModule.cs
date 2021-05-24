using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace QuetoServer.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(QuetoServerBlazorModule)
        )]
    public class QuetoServerBlazorServerModule : AbpModule
    {
        
    }
}