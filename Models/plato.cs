using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantee.Models
{
    public class plato
    {
        [Key]
        public int idPlatos { get; set; }

        public String Nombre { get; set; }

        [DisplayName("Costo")]
        [Required(ErrorMessage = "Completar el campo {0}")]
        public int Precio { get; set; }

        public int Cantidad { get; set; }
    }
}
