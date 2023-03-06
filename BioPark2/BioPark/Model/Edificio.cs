using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BioPark.Model
{
    public class Edificio
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int ApartamentoId { get; set; }
        [JsonIgnore]
        public virtual List<Apartamento> Apartamentos { get; set; }
    }
}
