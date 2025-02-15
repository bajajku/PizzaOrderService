﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaStore.DB;

#nullable disable

namespace PizzaStore.Migrations
{
    [DbContext(typeof(PizzaDB))]
    [Migration("20250207150202_SeedPizzas")]
    partial class SeedPizzas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("PizzaStore.DB.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://http.pizza/100.jpg",
                            Name = "Montemagno, Pizza shaped like a great mountain"
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://http.pizza/101.jpg",
                            Name = "The Galloway, Pizza shaped like a submarine, silent but deadly"
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://http.pizza/102.jpg",
                            Name = "The Noring, Pizza shaped like a Viking helmet, where's the mead"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
