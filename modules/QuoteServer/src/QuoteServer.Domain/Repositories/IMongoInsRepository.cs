using QuoteServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace QuoteServer.Repositories
{
    public interface IMongoInsRepository : IBasicRepository<Ins, Guid>
    {
    }
}
