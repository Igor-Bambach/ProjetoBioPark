using AutoMapper;
using BioPark.Data;
using BioPark.Data.Dtos.ApartamentoDto;
using BioPark.Model;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BioPark.Repository
{
    public class ApartamentoRepository
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ApartamentoRepository(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Result CadastrarApartamento(Apartamento apartamento)
        {
            _context.Apartamentos.Add(apartamento);
            _context.SaveChanges();
            return Result.Ok();
        }

        public List<LerApartamentoDto> PesquisaApartamentoPorDisponibilidade(bool disponibilidade)
        {
            var apartamento = _context.Apartamentos.Where(ap => ap.Disponibilidade == disponibilidade).ToList();
            var dto = _mapper.Map<List<LerApartamentoDto>>(apartamento);
            return dto;
        }
    }
}
