using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ejemplo.Models
{
    public class Modelos
    {
        [Key]
        public int modeloID { get; set; }

        public string nombre { get; set; }
        public decimal costo { get; set; }
        public string ram { get; set; }
        public string procesador { get; set; }
        public string discoDuro { get; set; }
        public string dimenciones { get; set; }


    }
}