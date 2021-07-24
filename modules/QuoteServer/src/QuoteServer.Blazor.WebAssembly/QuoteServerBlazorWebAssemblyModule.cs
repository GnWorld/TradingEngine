using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace QuoteServer.Blazor.WebAssembly
{
    [DependsOn(
        typeof(QuoteServerBlazorModule),
        typeof(QuoteServerHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class QuoteServerBlazorWebAssemblyModule : AbpModule
    {
        
    }
}