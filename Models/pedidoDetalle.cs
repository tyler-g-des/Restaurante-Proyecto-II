using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantee.Models
{
    public class pedidoDetalle
    {
        [Key]
        public int idPedidoDetalle { get; set; }

        [Display(Name = "Plato")]
        [ForeignKey("idPlatos")]
        public int idPlatos { get; set; }
        public plato plato { get; set; }

        public int cantidad { get; set; }

        public decimal subTotal { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        [Display(Name = "Precio")]
        public decimal precio { get; set; }

        [Display(Name = "Pedido")]
        [ForeignKey("idPedido")]
        public int idPedido { get; set; }
        public pedido pedido { get; set; }

    }
}
