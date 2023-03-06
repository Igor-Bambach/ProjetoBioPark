using System.ComponentModel.DataAnnotations;

namespace BioPark.Model
{
    public class Apartamento
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Numero { get; set; }
        public string Locador { get; set; }
        public string Locatario { get; set; } = "BioPark";
        public double Valor { get; set; }
        public bool Disponibilidade { get; set; } = true;
        public virtual Edificio Edificios { get; set; }
        public int EdificioId { get; set; }
    }
}
