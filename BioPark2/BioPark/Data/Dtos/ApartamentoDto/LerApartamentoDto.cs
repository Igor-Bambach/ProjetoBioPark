namespace BioPark.Data.Dtos.ApartamentoDto
{
    public class LerApartamentoDto
    {
        public string Numero { get; set; }
        public string Locador { get; set; }
        public string Locatario { get; set; }
        public double Valor { get; set; }
        public bool Disponibilidade { get; set; } = true;
        public int EdificioId { get; set; }
    }
}
