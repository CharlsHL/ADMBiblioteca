namespace Modelos
{
    public class Cuota
    {
        public Socio Socio { get; set; }
        public DateTime FechaPago { get; set; }

        public decimal MontoPagar { get; set; }

        public Cuota(Socio socio,DateTime fechaPago ,decimal montoPagar)
        {
            this.Socio = socio; 
            this.FechaPago = fechaPago; 
            this.MontoPagar = montoPagar;
        }
    }
}
