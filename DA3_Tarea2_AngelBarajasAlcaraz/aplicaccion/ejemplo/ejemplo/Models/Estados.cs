using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ejemplo.Models
{
    public class Estados
    {
        [Key]
        public int estadoID { get; set; }

        public string nombre { get; set; }

        public virtual ICollection< Municipios> municipios { get; set; }
    }
}