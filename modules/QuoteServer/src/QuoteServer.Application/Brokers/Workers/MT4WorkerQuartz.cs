using Quartz;
using QuoteServer.Domain.Entities;
using QuoteServer.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.BackgroundWorkers.Quartz;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Timing;
using YT.Core.FileHelper;
using QuoteServer.AppService;

namespace QuoteServer.Brokers
{
    public class MT4WorkerQuartz : QuartzBackgroundWorkerBase
    {
        private readonly Clock _clock;
        private IRepository<Cur> _curRep;
        private IRepository<Ins> _insRep;
        private readonly IInsAppService _insAppService;
        private readonly ICurrencyAppService _curAppService;

        public MT4WorkerQuartz(Clock clock, IRepository<Cur> curRep, IRepository<Ins> insRep, IInsAppService insAppService, ICurrencyAppService curAppService)
        {

            JobDetail = JobBuilder.Create<MT4WorkerQuartz>().WithIdentity(nameof(MT4WorkerQuartz)).Build();
            Trigger = TriggerBuilder.Create().WithIdentity(nameof(MT4WorkerQuartz)).WithSimpleSchedule(x => x.WithInterval(TimeSpan.FromMilliseconds(1)).RepeatForever()).StartNow().Build();

            _clock = clock;
            _curRep = curRep;
            _insRep = insRep;
            _insAppService = insAppService;
            _curAppService = curAppService;
        }

        public override async Task Execute(IJobExecutionContext context)
        {
            await ProcessPrices();
        }
        private async Task ProcessPrices()
        {
            foreach (var item in ConstFields.MT4Sourcies_Enable)
            {

                var path = ConstFields.GetMT4Path(item.MT4Key);
                var f_metadata = path + @"\metadata.txt";
                var f_prices = path + @"\tick\prices.txt";
                if (File.Exists(f_prices))
                {
                    var lines = FileOperation.TryReadAllLines(f_prices);
                    var prices = new List<InsPriceDto>();
                    for (int i = 0; i < lines.Length; i++)
                    {

                        var line = lines[i].Split(";");
                        if (lines.Length > 1)
                        {
                            Console.WriteLine(line[0]);
                            var input = new InsPriceDto();
                            input.Code = item.MT4Name + ":" + line[0];
                            input.Ask = decimal.Parse(line[1]);
                            input.Bid = decimal.Parse(line[2]);
                            input.Tick = long.Parse(line[3]);
                            prices.Add(input);

                        }
                    }
                    await _insAppService.UpdateInsPriceAsync(prices);
                }
            }
        }
    }
}
