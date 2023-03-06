using System.ComponentModel.DataAnnotations;

namespace BioPark.Data.Dtos.EdificioDto
{
    public class CriarEdificioDto
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        public int ApartamentoId { get; set; }
    }
}
