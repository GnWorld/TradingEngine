using QuetoServer.Coins;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace QuetoServer.Repositories
{
    public interface ICoinRepository :IRepository<Coin,Guid>
    {
        Task<int> ExcuteAsync();
    }
}
