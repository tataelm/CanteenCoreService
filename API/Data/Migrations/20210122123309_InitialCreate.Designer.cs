﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210122123309_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("API.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("FoodTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FoodTypeId");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("API.Entities.FoodPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Food1")
                        .HasColumnType("TEXT");

                    b.Property<string>("Food2")
                        .HasColumnType("TEXT");

                    b.Property<string>("Food3")
                        .HasColumnType("TEXT");

                    b.Property<string>("Food4")
                        .HasColumnType("TEXT");

                    b.Property<string>("Food5")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FoodPlans");
                });

            modelBuilder.Entity("API.Entities.FoodType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("FoodTypes");
                });

            modelBuilder.Entity("API.Entities.Food", b =>
                {
                    b.HasOne("API.Entities.FoodType", "FoodType")
                        .WithMany()
                        .HasForeignKey("FoodTypeId");

                    b.Navigation("FoodType");
                });
#pragma warning restore 612, 618
        }
    }
}
