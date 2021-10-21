using QuoteServer.AppService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuoteServer.AppService
{
    public interface ICurrencyAppService : IApplicationService
    {

        /// <summary>
        /// 添加币种
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<CurOutput> AddAsync(CreateCurInput input);

        /// <summary>
        /// 更新币种
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<CurOutput> UpdateCurAsync(UpdateCurInput input);

        /// <summary>
        /// 更新币种汇率
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task UpdateCurRateAsync(UpdateCurRateInput input);

        /// <summary>
        /// 获取币种
        /// </summary>
        /// <param name="curCode"></param>
        /// <returns></returns>
        Task<CurOutput> GetCurAsync(string curCode);

        // <summary>
        ///获取币种列表
        /// </summary>
        /// <param name="curCode"></param>
        /// <returns></returns>
        Task<List<CurOutput>> GetCursAsync(string curCode = null);


    }
}
