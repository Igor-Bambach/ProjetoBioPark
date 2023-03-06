using BioPark.Data;
using BioPark.Model;
using FluentResults;
using System;

namespace BioPark.Repository
{
    public class EdificioRepository
    {
        private readonly AppDbContext _context;

        public EdificioRepository(AppDbContext context)
        {
            _context = context;
        }

        public Result CadastrarEdificio(Edificio edificio)
        {
            _context.Edificios.Add(edificio);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
