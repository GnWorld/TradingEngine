using AutoMapper;
using QuetoServer.Coins;
using QuetoServer.Services;

namespace QuetoServer
{
    public class QuetoServerApplicationAutoMapperProfile : Profile
    {
        public QuetoServerApplicationAutoMapperProfile()
        {

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Coin, CoinDto>();
        }
    }
}