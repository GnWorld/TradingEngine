using AutoMapper;
using QuetoServer.Curs;
using QuetoServer.Services;
using System;
using System.Collections.Generic;
using Volo.Abp.AutoMapper;

namespace QuetoServer
{
    public class QuetoServerApplicationAutoMapperProfile : Profile
    {
        public QuetoServerApplicationAutoMapperProfile()
        {

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<CreateCurInput, Cur>().IgnoreFullAuditedObjectProperties();
            CreateMap<UpdateCurInput, Cur>().IgnoreFullAuditedObjectProperties();

            CreateMap<Cur, CurOutput>();
        }
    }
}