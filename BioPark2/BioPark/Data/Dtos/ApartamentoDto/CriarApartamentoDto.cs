using System.ComponentModel.DataAnnotations;

namespace BioPark.Data.Dtos.ApartamentoDto
{
    public class CriarApartamentoDto
    {
        [Required]
        public string Numero { get; set; }
        [Required]
        public string Locador { get; set; }
        [Required]
        public double Valor { get; set; }
        [Required]
        public bool Disponibilidade { get; set; } = true;
        public int EdificioId { get; set; }
    }
}
