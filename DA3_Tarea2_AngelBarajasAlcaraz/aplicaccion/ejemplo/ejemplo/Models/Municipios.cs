using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ejemplo.Models
{
    public class Municipios
    {
        [Key]
        public int municipioID { get; set; }

        public string nombre { get; set; }

        public int estadoID { get; set; }
        public virtual Estados estado { get; set; }
    }
}