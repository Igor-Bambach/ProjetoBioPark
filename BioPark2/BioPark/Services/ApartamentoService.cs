using AutoMapper;
using BioPark.Data.Dtos.ApartamentoDto;
using BioPark.Model;
using BioPark.Repository;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BioPark.Services
{
    public class ApartamentoService
    {
        private readonly ApartamentoRepository _repository;
        private readonly IMapper _mapper;

        public ApartamentoService(ApartamentoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Result CadastrarApartamento(CriarApartamentoDto apartamentoDto)
        {
            if (string.IsNullOrEmpty(apartamentoDto.Locador))
            {
                var apartamento = _mapper.Map<Apartamento>(apartamentoDto);
                Result cadastro = _repository.CadastrarApartamento(apartamento);
                return Result.Ok();
            }
            var apartamentoOcupado = _mapper.Map<Apartamento>(apartamentoDto);
            apartamentoOcupado.Disponibilidade = false;
            Result cadastroOcupado = _repository.CadastrarApartamento(apartamentoOcupado);
            return Result.Ok();


        }

        public List<LerApartamentoDto> PesquisaApartamentoPorDisponibilidade(bool disponibilidade)
        {
            var pesquisa = _repository.PesquisaApartamentoPorDisponibilidade(disponibilidade);
            return pesquisa;
        }
    }
}
