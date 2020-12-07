using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurantee.Models;

namespace PrimerParcial.Data
{
    public class DataContext : DbContext 
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Restaurantee.Models.usuario> usuario { get; set; }

        public DbSet<Restaurantee.Models.mesa> mesas { get; set; }

        public DbSet<Restaurantee.Models.clasificacionIngredientes> clasificacionIngredientes { get; set; }

        public DbSet<Restaurantee.Models.inventario> inventarios { get; set; }

        public DbSet<Restaurantee.Models.pedido> pedidos { get; set; }

        public DbSet<Restaurantee.Models.pedidoDetalle> pedidoDetalles { get; set; }

        public DbSet<Restaurantee.Models.plato> plato { get; set; }
    }
}
