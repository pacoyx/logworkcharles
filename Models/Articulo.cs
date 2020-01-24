using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Articulo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
        public string Categoria { get; set; }        
        public string Familia { get; set; }
        public decimal Precio { get; set; }
    }
}