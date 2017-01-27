using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ejemplo.Models
{
    public class Producto
    {
        [Key]
        public int prodictoID { get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }

    }
}