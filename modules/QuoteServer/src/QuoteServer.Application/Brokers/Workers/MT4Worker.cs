using Microsoft.Extensions.DependencyInjection;
using QuoteServer.AppService;
using QuoteServer.AppService.Dtos;
using QuoteServer.Domain.Entities;
using System;
using System.IO;
using System.Threading.Tasks;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Threading;
using Volo.Abp.Timing;
using YT.Core;
using YT.Core.FileHelper;

namespace QuoteServer.Brokers
{
    public class MT4Worker : AsyncPeriodicBackgroundWorkerBase
    {
        private readonly Clock _clock;
        //private IRepository<Cur> _curRep;
        //private IRepository<Ins> _insRep;
        //private readonly IInsAppService _insAppService;
        //private readonly ICurrencyAppService _curAppService;
        private readonly IBrokerAppService _brokerAppService;
        public MT4Worker(AbpAsyncTimer timer, IServiceScopeFactory serviceScopeFactory, Clock clock) : base(timer, serviceScopeFactory)
        {
            var serviceFactory = serviceScopeFactory.CreateScope();
            //_curAppService = serviceFactory.ServiceProvider.GetService<ICurrencyAppService>();
            //_insAppService = serviceFactory.ServiceProvider.GetService<IInsAppService>();
            //_curRep = serviceFactory.ServiceProvider.GetRequiredService<IRepository<Cur>>();
            //_insRep = serviceFactory.ServiceProvider.GetRequiredService<IRepository<Ins>>();
            _brokerAppService = serviceFactory.ServiceProvider.GetRequiredService<IBrokerAppService>();
            _clock = clock;
            timer.Period = 1; // 1毫秒执行一次
            timer.Logger = null;

        }

        protected async override Task DoWorkAsync(PeriodicBackgroundWorkerContext workerContext)
        {
            using var cw = new CodeWrapper("MT4Worker");
            //
            //
            await ProcessPrices();
        }
        private async Task ProcessPrices()
        {
            foreach (var item in ConstFields.MT4Sourcies)
            {

                var path = ConstFields.GetMT4Path(item.MT4Key);
                var f_metadata = path + @"\metadata.txt";
                var f_prices = path + @"\tick\prices.txt";
                if (File.Exists(f_prices))
                {
                    var prices = FileOperation.TryReadAllLines(f_prices);
                    Console.WriteLine(prices[0]);
                    for (int i = 0; i < prices.Length; i++)
                    {

                        var lines = prices[i].Split(";");
                        if (lines.Length > 1)
                        {
                            var input = new InsPriceDto();
                            input.Code = item.MT4Name + ":" + lines[0];
                            input.Ask = decimal.Parse(lines[1]);
                            input.Bid = decimal.Parse(lines[2]);
                            input.Tick = long.Parse(lines[3]);
                            await _brokerAppService.CommitPriceAsync(input);
                            //await _insAppService.UpdateInsPriceAsync(input);
                        }
                    }
                }

                var n = 0;
            }

        }
    }
}
