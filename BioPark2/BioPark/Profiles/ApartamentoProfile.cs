using AutoMapper;
using BioPark.Data.Dtos.ApartamentoDto;
using BioPark.Model;

namespace BioPark.Profiles
{
    public class ApartamentoProfile : Profile
    {
        public ApartamentoProfile()
        {
            CreateMap<Apartamento, CriarApartamentoDto>();
            CreateMap<CriarApartamentoDto, Apartamento>();
            CreateMap<LerApartamentoDto, Apartamento>();
            CreateMap<Apartamento, LerApartamentoDto>();
        }
    }
}
