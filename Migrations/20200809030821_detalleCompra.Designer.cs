﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimerParcial.Data;

namespace PrimerParcial.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200809030821_detalleCompra")]
    partial class detalleCompra
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PrimerParcial.Models.Clasificaciones.ClasificacionArticulos", b =>
                {
                    b.Property<int>("idClasificacionArticulos")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoDeArticulos");

                    b.HasKey("idClasificacionArticulos");

                    b.ToTable("ClasificacionArticulos");
                });

            modelBuilder.Entity("PrimerParcial.Models.Clasificaciones.ClasificacionCliente", b =>
                {
                    b.Property<int>("idClasificacionCliente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoDeCliente");

                    b.HasKey("idClasificacionCliente");

                    b.ToTable("clasificacionClientes");
                });

            modelBuilder.Entity("PrimerParcial.Models.Clasificaciones.ClasificacionSuplidor", b =>
                {
                    b.Property<int>("idClasificacionSuplidor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoDeSuplidor");

                    b.HasKey("idClasificacionSuplidor");

                    b.ToTable("ClasificacionSuplidor");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Articulo", b =>
                {
                    b.Property<int>("idArticulo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad");

                    b.Property<string>("Nombre");

                    b.Property<int>("Precio");

                    b.Property<int>("idClasificacionArticulos");

                    b.Property<int>("idMarca");

                    b.HasKey("idArticulo");

                    b.HasIndex("idClasificacionArticulos");

                    b.HasIndex("idMarca");

                    b.ToTable("Articulo");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Ciudad", b =>
                {
                    b.Property<int>("idCiudad")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<int>("idPais");

                    b.Property<string>("nombre");

                    b.HasKey("idCiudad");

                    b.HasIndex("idPais");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Cliente", b =>
                {
                    b.Property<int>("idCliente")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion");

                    b.Property<int?>("DocumentoidTipoDeDocumento");

                    b.Property<string>("email");

                    b.Property<int>("idCiudad");

                    b.Property<int>("idClasificacionCliente");

                    b.Property<int>("idTipoDocumento");

                    b.Property<string>("nombre");

                    b.Property<string>("telefono");

                    b.HasKey("idCliente");

                    b.HasIndex("DocumentoidTipoDeDocumento");

                    b.HasIndex("idCiudad");

                    b.HasIndex("idClasificacionCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Compra", b =>
                {
                    b.Property<int>("compraID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fechaOrden");

                    b.Property<int>("formaEnvioID");

                    b.Property<int>("formaPagoID");

                    b.Property<int>("idCliente");

                    b.Property<decimal>("impuesto");

                    b.Property<string>("observacion");

                    b.Property<decimal>("subtotal");

                    b.Property<decimal>("total");

                    b.HasKey("compraID");

                    b.HasIndex("formaEnvioID");

                    b.HasIndex("formaPagoID");

                    b.HasIndex("idCliente");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.CompraDetalle", b =>
                {
                    b.Property<int>("compraDetallID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("cantidad");

                    b.Property<int>("compraID");

                    b.Property<int>("idArticulo");

                    b.Property<decimal>("precio");

                    b.Property<decimal>("precioTotal");

                    b.HasKey("compraDetallID");

                    b.HasIndex("compraID");

                    b.HasIndex("idArticulo");

                    b.ToTable("compraDetalles");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Empleado", b =>
                {
                    b.Property<int>("idEmpleado")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion");

                    b.Property<int?>("DocumentoidTipoDeDocumento");

                    b.Property<string>("email");

                    b.Property<int>("idCiudad");

                    b.Property<int>("idEmpresa");

                    b.Property<int>("idTipoDocumento");

                    b.Property<string>("nombre");

                    b.Property<string>("telefono");

                    b.HasKey("idEmpleado");

                    b.HasIndex("DocumentoidTipoDeDocumento");

                    b.HasIndex("idCiudad");

                    b.HasIndex("idEmpresa");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Empresa", b =>
                {
                    b.Property<int>("idEmpresa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodPostal");

                    b.Property<string>("Direccion");

                    b.Property<int>("idUbicacion");

                    b.Property<string>("nombre");

                    b.Property<string>("telefono");

                    b.HasKey("idEmpresa");

                    b.HasIndex("idUbicacion");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.formaEnvio", b =>
                {
                    b.Property<int>("formaEnvioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("formaEnvioDescripcion")
                        .IsRequired();

                    b.HasKey("formaEnvioID");

                    b.ToTable("formaEnvios");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.formaPago", b =>
                {
                    b.Property<int>("formaPagoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("formaPagoDescripcion")
                        .IsRequired();

                    b.HasKey("formaPagoID");

                    b.ToTable("formaPagos");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Marca", b =>
                {
                    b.Property<int>("idMarca")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.HasKey("idMarca");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Orden", b =>
                {
                    b.Property<int>("ordenID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("fechaOrden");

                    b.Property<int>("formaEnvioID");

                    b.Property<int>("formaPagoID");

                    b.Property<int>("idSuplidor");

                    b.Property<decimal>("impuesto");

                    b.Property<string>("observacion");

                    b.Property<decimal>("subtotal");

                    b.Property<decimal>("total");

                    b.HasKey("ordenID");

                    b.HasIndex("formaEnvioID");

                    b.HasIndex("formaPagoID");

                    b.HasIndex("idSuplidor");

                    b.ToTable("Ordens");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.OrdenDetalle", b =>
                {
                    b.Property<int>("ordenDetallID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("cantidad");

                    b.Property<int>("idArticulo");

                    b.Property<int>("ordenID");

                    b.Property<decimal>("precio");

                    b.Property<decimal>("precioTotal");

                    b.HasKey("ordenDetallID");

                    b.HasIndex("idArticulo");

                    b.HasIndex("ordenID");

                    b.ToTable("ordenDetalles");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Pais", b =>
                {
                    b.Property<int>("idPais")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.Property<string>("nombre");

                    b.HasKey("idPais");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.PuestoDeTrabajo", b =>
                {
                    b.Property<int>("idPuesto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion");

                    b.Property<string>("nombre");

                    b.HasKey("idPuesto");

                    b.ToTable("puestoDeTrabajos");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Suplidor", b =>
                {
                    b.Property<int>("idSuplidor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<int>("idCiudad");

                    b.Property<int>("idClasificacionSuplidor");

                    b.Property<string>("nombre");

                    b.Property<string>("telefono");

                    b.HasKey("idSuplidor");

                    b.HasIndex("idCiudad");

                    b.HasIndex("idClasificacionSuplidor");

                    b.ToTable("Suplidor");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.TipoDeDocumento", b =>
                {
                    b.Property<int>("idTipoDeDocumento")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Documento");

                    b.Property<string>("Numero");

                    b.HasKey("idTipoDeDocumento");

                    b.ToTable("tipoDeDocumentos");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Ubicacion", b =>
                {
                    b.Property<int>("idUbicacion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Calle");

                    b.Property<int>("NoCasa");

                    b.Property<string>("Sector");

                    b.HasKey("idUbicacion");

                    b.ToTable("Ubicaciones");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Vendedor", b =>
                {
                    b.Property<int>("idVendedor")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion");

                    b.Property<int?>("DocumentoidTipoDeDocumento");

                    b.Property<string>("email");

                    b.Property<int>("idCiudad");

                    b.Property<int>("idTipoDocumento");

                    b.Property<string>("nombre");

                    b.Property<string>("telefono");

                    b.HasKey("idVendedor");

                    b.HasIndex("DocumentoidTipoDeDocumento");

                    b.HasIndex("idCiudad");

                    b.ToTable("Vendedores");
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Articulo", b =>
                {
                    b.HasOne("PrimerParcial.Models.Clasificaciones.ClasificacionArticulos", "ClasificacionArticulos")
                        .WithMany()
                        .HasForeignKey("idClasificacionArticulos")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Entidades.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("idMarca")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Ciudad", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("idPais")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Cliente", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.TipoDeDocumento", "Documento")
                        .WithMany()
                        .HasForeignKey("DocumentoidTipoDeDocumento");

                    b.HasOne("PrimerParcial.Models.Entidades.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("idCiudad")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Clasificaciones.ClasificacionCliente", "clasificacionCliente")
                        .WithMany()
                        .HasForeignKey("idClasificacionCliente")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Compra", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.formaEnvio", "FormaEnvio")
                        .WithMany()
                        .HasForeignKey("formaEnvioID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Entidades.formaPago", "FormaPago")
                        .WithMany()
                        .HasForeignKey("formaPagoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Entidades.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("idCliente")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.CompraDetalle", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("compraID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Entidades.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("idArticulo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Empleado", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.TipoDeDocumento", "Documento")
                        .WithMany()
                        .HasForeignKey("DocumentoidTipoDeDocumento");

                    b.HasOne("PrimerParcial.Models.Entidades.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("idCiudad")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Entidades.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("idEmpresa")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Empresa", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.Ubicacion", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("idUbicacion")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Orden", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.formaEnvio", "FormaEnvio")
                        .WithMany()
                        .HasForeignKey("formaEnvioID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Entidades.formaPago", "FormaPago")
                        .WithMany()
                        .HasForeignKey("formaPagoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Entidades.Suplidor", "Suplidor")
                        .WithMany()
                        .HasForeignKey("idSuplidor")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.OrdenDetalle", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.Articulo", "Articulo")
                        .WithMany()
                        .HasForeignKey("idArticulo")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Entidades.Orden", "Orden")
                        .WithMany()
                        .HasForeignKey("ordenID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Suplidor", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("idCiudad")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrimerParcial.Models.Clasificaciones.ClasificacionSuplidor", "clasificacionSuplidor")
                        .WithMany()
                        .HasForeignKey("idClasificacionSuplidor")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrimerParcial.Models.Entidades.Vendedor", b =>
                {
                    b.HasOne("PrimerParcial.Models.Entidades.TipoDeDocumento", "Documento")
                        .WithMany()
                        .HasForeignKey("DocumentoidTipoDeDocumento");

                    b.HasOne("PrimerParcial.Models.Entidades.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("idCiudad")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
