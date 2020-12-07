using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantee.Models
{
    public class pedido
    {
        [Key]
        public int idPedido { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        public String persona { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime fechaPedido { get; set;}

        public decimal subTotal { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public bool estado { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        public String observaciones { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        [Display(Name = "Mesa")]
        [ForeignKey("idMesa")]
        public int idMesa { get; set; }
        public mesa mesa { get; set; }

        [Required(ErrorMessage = "Es obligatorio")]
        [Display(Name = "Plato")]
        [ForeignKey("idPlato")]
        public int idPlato { get; set; }
        public plato plato { get; set; }
    }
}
