﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimerParcial.Data;

namespace Restaurantee.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201127173506_clasificacion-ingredientes")]
    partial class clasificacioningredientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Restaurantee.Models.clasificacionIngredientes", b =>
                {
                    b.Property<int>("idClasificacionIngredientes")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tipoClientes");

                    b.HasKey("idClasificacionIngredientes");

                    b.ToTable("clasificacionIngredientes");
                });

            modelBuilder.Entity("Restaurantee.Models.mesa", b =>
                {
                    b.Property<int>("idMesa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion");

                    b.Property<string>("estado");

                    b.Property<int>("numeroMaximoDePersonas");

                    b.Property<string>("ubicacion");

                    b.HasKey("idMesa");

                    b.ToTable("mesas");
                });

            modelBuilder.Entity("Restaurantee.Models.usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido");

                    b.Property<string>("clave");

                    b.Property<string>("direccion");

                    b.Property<string>("nombre");

                    b.Property<string>("role");

                    b.Property<string>("telefono");

                    b.HasKey("idUsuario");

                    b.ToTable("usuario");
                });
#pragma warning restore 612, 618
        }
    }
}