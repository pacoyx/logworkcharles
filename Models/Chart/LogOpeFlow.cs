using System.Collections.Generic;
namespace RazorPagesMovie.Models{

    public class LogOpeFlow
    {
        public string Fecha { get; set; }
        public string Cliente { get; set; }
        public string Tipo { get; set; }
        public string Operacion { get; set; }
        public double Cant_trx { get; set; }
    }
    
}