using QuoteServer.Instrument.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace QuoteServer.Instrument
{
    public class InsAppService : QuoteServerAppService, IInsAppService
    {
        private readonly IRepository<Ins> _insRep;

        private readonly IUnitOfWork _uow;

        public InsAppService(IRepository<Ins> insRep, IUnitOfWork uow)
        {
            _insRep = insRep;
            _uow = uow;
        }

        public async Task<InsDto> AddInsAsync(InsDto input)
        {
            var entity = ObjectMapper.Map<InsDto, Ins>(input);
            var cur = await _insRep.InsertAsync(entity, true);
            var output = ObjectMapper.Map<Ins, InsDto>(cur);
            return output;
        }
    }
}
