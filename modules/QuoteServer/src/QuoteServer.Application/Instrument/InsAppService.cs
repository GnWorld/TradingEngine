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
            var ins = await _insRep.InsertAsync(entity, true);
            var output = ObjectMapper.Map<Ins, InsDto>(ins);
            return output;
        }


        public async Task<InsDto> GetInsByCodeAsync(string Code)
        {
            var ins = await _insRep.GetAsync(o => o.Code == Code);

            var output = ObjectMapper.Map<Ins, InsDto>(ins);
            return output;
        }

        public async Task UpdateInsPriceAsync(InsPriceDto input)
        {
            var ins = await _insRep.GetAsync(o => o.Code == input.Code);
            if (ins.Ask != input.Ask || ins.Bid != input.Bid)
            {
                ins.Ask = input.Ask;
                ins.Bid = input.Bid;
                ins.LastModificationTime = DateTime.FromFileTimeUtc(input.Tick);
                //await _insRep.UpdateAsync(ins, true);
            }
        }
    }
}
