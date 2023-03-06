using BioPark.Model;
using Microsoft.EntityFrameworkCore;

namespace BioPark.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Apartamento>()
                .HasOne(s => s.Edificios)
                .WithMany(e => e.Apartamentos)
                .HasForeignKey(s => s.EdificioId);

            builder.Entity<Edificio>()
                .HasData(
                new Edificio { Id = 1, Nome = "A", ApartamentoId = 1 },
                new Edificio { Id = 2, Nome = "B", ApartamentoId = 3 }
                );

            builder.Entity<Apartamento>()
                .HasData(
                new Apartamento { ID = 1, Numero = "25", Locador = "Bruno", Valor = 560, Disponibilidade = false, EdificioId = 1 },
                new Apartamento { ID = 2, Numero = "55", Locador = "Felipe", Valor = 600, Disponibilidade = false, EdificioId = 1 },
                new Apartamento { ID = 3, Numero = "84", Locador = "Luiza", Valor = 700, Disponibilidade = false, EdificioId = 1 },
                new Apartamento { ID = 4, Numero = "110", Locador = "Gabriela", Valor = 800, Disponibilidade = false, EdificioId = 1 },
                new Apartamento { ID = 5, Numero = "65", Locador = "Antonio", Valor = 625, Disponibilidade = false, EdificioId = 1 },
                new Apartamento { ID = 6, Numero = "56", Locador = null, Valor = 600, Disponibilidade = true, EdificioId = 1 },
                new Apartamento { ID = 7, Numero = "77", Locador = "Marcelo", Valor = 650, Disponibilidade = false, EdificioId = 1 },
                new Apartamento { ID = 8, Numero = "12", Locador = null, Valor = 400, Disponibilidade = true, EdificioId = 1 },
                new Apartamento { ID = 9, Numero = "13", Locador = null, Valor = 400, Disponibilidade = true, EdificioId = 1 },
                new Apartamento { ID = 10, Numero = "10", Locador = null, Valor = 900, Disponibilidade = true, EdificioId = 2 },
                new Apartamento { ID = 11, Numero = "11", Locador = "Bruna", Valor = 560, Disponibilidade = false, EdificioId = 2 },
                new Apartamento { ID = 12, Numero = "12", Locador = null, Valor = 560, Disponibilidade = true, EdificioId = 2 },
                new Apartamento { ID = 13, Numero = "13", Locador = "Aurelio", Valor = 905, Disponibilidade = false, EdificioId = 2 },
                new Apartamento { ID = 14, Numero = "14", Locador = "Maicon", Valor = 999, Disponibilidade = false, EdificioId = 2 },
                new Apartamento { ID = 15, Numero = "15", Locador = null, Valor = 945, Disponibilidade = true, EdificioId = 2 },
                new Apartamento { ID = 16, Numero = "16", Locador = "Marcio", Valor = 945, Disponibilidade = false, EdificioId = 2 },
                new Apartamento { ID = 17, Numero = "17", Locador = "Marcio", Valor = 330, Disponibilidade = false, EdificioId = 2 },
                new Apartamento { ID = 18, Numero = "18", Locador = null, Valor = 901, Disponibilidade = true, EdificioId = 2 }
                );

        }

        public DbSet<Apartamento> Apartamentos { get; set; }
        public DbSet<Edificio> Edificios { get; set; }
    }
}
