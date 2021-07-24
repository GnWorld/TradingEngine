using AutoMapper;
using QuoteServer.Currency;
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
            CreateMap<CreateCurInput, Cur>().IgnoreFullAuditedObjectProperties().Ignore(o => o.Id);
            CreateMap<UpdateCurInput, Cur>().IgnoreFullAuditedObjectProperties();

            CreateMap<Cur, CurOutput>();
        }
    }
}