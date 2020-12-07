using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantee.Models
{
    public class inventario
    {
        [Key]
        public int idInventario { get; set; }

        public String ingrediente { get; set; }

        public int cantidad { get; set; }


        [Display(Name = "Tipo de ingredientes")]
        [ForeignKey("idClasificacionIngredientes")]
        public int idClasificacionIngredientes { get; set; }
        public clasificacionIngredientes clasificacion { get; set; }
    }
}
