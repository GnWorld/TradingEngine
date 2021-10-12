using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace AccountServer.Samples
{
    public interface ISampleAppService : IApplicationService
    {
        Task<SampleDto> GetAsync();

        Task<SampleDto> GetAuthorizedAsync();
    }
}
