using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantee.Models
{  
    public class mesa
    {
        [Key]
        public int idMesa { get; set; }

        public int numeroMaximoDePersonas { get; set; }

        public String ubicacion { get; set; }

        public String  descripcion { get; set; }

        public String estado { get; set; }
    }
}
