using QuoteServer.Currency;
using QuoteServer.Instrument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace QuoteServer
{
    public class Broker
    {
        private readonly IRepository<Cur> _curRep;
        private readonly IRepository<Ins> _insRep;
    }
}
