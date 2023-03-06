using AutoMapper;
using BioPark.Data.Dtos.EdificioDto;
using BioPark.Model;

namespace BioPark.Profiles
{
    public class EdificioProfile : Profile
    {
        public EdificioProfile()
        {
            CreateMap<Edificio, CriarEdificioDto>();
            CreateMap<CriarEdificioDto, Edificio>();
        }
    }
}
