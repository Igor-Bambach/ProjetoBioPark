using AutoMapper;
using BioPark.Data.Dtos.EdificioDto;
using BioPark.Model;
using BioPark.Repository;
using FluentResults;
using System;

namespace BioPark.Services
{
    public class EdificioService
    {
        private readonly EdificioRepository _repository;
        private readonly IMapper _mapper;

        public EdificioService(EdificioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Result CadastrarEdificio(CriarEdificioDto criarDto)
        {
            var edificio = _mapper.Map<Edificio>(criarDto);
            Result cadastrar = _repository.CadastrarEdificio(edificio);
            if (cadastrar.IsFailed)
            {
                return Result.Fail(cadastrar.Errors);
            }
            return Result.Ok();
        }
    }
}
