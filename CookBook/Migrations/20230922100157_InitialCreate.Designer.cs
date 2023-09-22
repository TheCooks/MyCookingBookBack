﻿// <auto-generated />
using CookBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CookBook.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230922100157_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CookBook.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("longtext");

                    b.Property<string>("Ingredients")
                        .HasColumnType("longtext");

                    b.Property<string>("Instructions")
                        .HasColumnType("longtext");

                    b.Property<int>("NumPers")
                        .HasColumnType("int");

                    b.Property<string>("RecipeName")
                        .HasColumnType("longtext");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}