using QuetoServer.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuetoServer.Services
{
    public interface ICoinAppService : IApplicationService
    {

        Task AddCoinAsync();

        Task UpdateCoinAsync();
    }
}
