using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace QuetoServer.Blazor.WebAssembly
{
    [DependsOn(
        typeof(QuetoServerBlazorModule),
        typeof(QuetoServerHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class QuetoServerBlazorWebAssemblyModule : AbpModule
    {
        
    }
}