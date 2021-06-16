using AutoMapper;
using QuetoServer.Coins;
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
            CreateMap<CreateCoinInput, Coin>()
                .Ignore(o => o.CreateTime)
                .Ignore(o => o.UpdateTime)
                .Ignore(o => o.Creator)
                .Ignore(o => o.Id);

            CreateMap<Coin, CoinOutput>()
                .ForMember(o => o.UpdateTime, option => option.MapFrom(b => DateTime.FromBinary(b.UpdateTime)))
                .ForMember(o => o.CreateTime, option => option.MapFrom(b => DateTime.FromBinary(b.CreateTime)));

            CreateMap<UpdateCoinInput, Coin>()
                .Ignore(o => o.CreateTime)
                .Ignore(o => o.UpdateTime)
                .Ignore(o => o.Creator);

        }
    }
}