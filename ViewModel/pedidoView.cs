using Restaurantee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurantee.ViewModel
{
    public class pedidoView
    {
        public pedido pedido { get; set; }

        public pedidoDetalle pedidoDetalle { get; set; }

        public List<pedidoDetalle> pedidos { get; set; }
    }
}
