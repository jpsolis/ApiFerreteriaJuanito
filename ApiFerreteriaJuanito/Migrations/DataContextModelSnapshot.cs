﻿// <auto-generated />
using ApiFerreteriaJuanito.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiFerreteriaJuanito.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("ApiFerreteriaJuanito.Producto", b =>
                {
                    b.Property<int>("idProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("precio")
                        .HasColumnType("INTEGER");

                    b.HasKey("idProducto");

                    b.ToTable("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
