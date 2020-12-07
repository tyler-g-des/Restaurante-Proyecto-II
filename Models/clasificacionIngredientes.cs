using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantee.Models
{
    public class clasificacionIngredientes
    {
        [Key]
        public int idClasificacionIngredientes { get; set; }

        [Display(Name = "clasificacion clientes")]
        public String tipoClientes { get; set; } 

    }
}
