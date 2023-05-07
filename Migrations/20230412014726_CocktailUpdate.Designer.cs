﻿// <auto-generated />
using System;
using Bartendroid.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bartendroid.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230412014726_CocktailUpdate")]
    partial class CocktailUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Bartendroid.Models.Batch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Batches");
                });

            modelBuilder.Entity("Bartendroid.Models.Cocktail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Instructions")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cocktail");
                });

            modelBuilder.Entity("Bartendroid.Models.CocktailIngredient", b =>
                {
                    b.Property<int>("CocktailId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("TEXT");

                    b.HasKey("CocktailId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("CocktailIngredients");
                });

            modelBuilder.Entity("Bartendroid.Models.Container", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BatchId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Position")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Volume")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("IngredientId");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("Bartendroid.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Bartendroid.Models.CocktailIngredient", b =>
                {
                    b.HasOne("Bartendroid.Models.Cocktail", "Cocktail")
                        .WithMany("CocktailIngredients")
                        .HasForeignKey("CocktailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bartendroid.Models.Ingredient", "Ingredient")
                        .WithMany("CocktailIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cocktail");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Bartendroid.Models.Container", b =>
                {
                    b.HasOne("Bartendroid.Models.Batch", null)
                        .WithMany("Containers")
                        .HasForeignKey("BatchId");

                    b.HasOne("Bartendroid.Models.Ingredient", "Ingredient")
                        .WithMany("Containers")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Bartendroid.Models.Batch", b =>
                {
                    b.Navigation("Containers");
                });

            modelBuilder.Entity("Bartendroid.Models.Cocktail", b =>
                {
                    b.Navigation("CocktailIngredients");
                });

            modelBuilder.Entity("Bartendroid.Models.Ingredient", b =>
                {
                    b.Navigation("CocktailIngredients");

                    b.Navigation("Containers");
                });
#pragma warning restore 612, 618
        }
    }
}