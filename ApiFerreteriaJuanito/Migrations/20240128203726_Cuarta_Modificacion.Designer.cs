﻿// <auto-generated />
using System;
using ApiFerreteriaJuanito.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiFerreteriaJuanito.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240128203726_Cuarta_Modificacion")]
    partial class Cuarta_Modificacion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("ApiFerreteriaJuanito.CarroCompras", b =>
                {
                    b.Property<int>("idCarro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("idUsuario")
                        .HasColumnType("INTEGER");

                    b.HasKey("idCarro");

                    b.ToTable("CarroCompras");
                });

            modelBuilder.Entity("ApiFerreteriaJuanito.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CarroComprasidCarro")
                        .HasColumnType("INTEGER");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("precio")
                        .HasColumnType("INTEGER");

                    b.HasKey("idProducto");

                    b.HasIndex("CarroComprasidCarro");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ApiFerreteriaJuanito.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("passUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("rangoUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ApiFerreteriaJuanito.Producto", b =>
                {
                    b.HasOne("ApiFerreteriaJuanito.CarroCompras", null)
                        .WithMany("listaProductos")
                        .HasForeignKey("CarroComprasidCarro");
                });

            modelBuilder.Entity("ApiFerreteriaJuanito.CarroCompras", b =>
                {
                    b.Navigation("listaProductos");
                });
#pragma warning restore 612, 618
        }
    }
}