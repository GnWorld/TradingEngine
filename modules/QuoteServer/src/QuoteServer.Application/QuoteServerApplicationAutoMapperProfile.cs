using AutoMapper;
using QuoteServer.AppService.Dtos;
using QuoteServer.Domain.Entities;
using Volo.Abp.AutoMapper;

namespace QuoteServer
{
    public class QuoteServerApplicationAutoMapperProfile : Profile
    {
        public QuoteServerApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            #region Cur
            CreateMap<CreateCurInput, Cur>().IgnoreFullAuditedObjectProperties().Ignore(o => o.Id);
            CreateMap<UpdateCurInput, Cur>().IgnoreFullAuditedObjectProperties();
            CreateMap<Cur, CurOutput>();
            #endregion

            #region Ins
            CreateMap<Ins, InsDto>();
            CreateMap<InsDto, Ins>().IgnoreFullAuditedObjectProperties().Ignore(o => o.Id);
            #endregion
        }
    }
}