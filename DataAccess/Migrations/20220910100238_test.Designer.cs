﻿// <auto-generated />
using DataAccess.Concrete.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(EntegraDbContext))]
    [Migration("20220910100238_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1223,
                            Name = "Finish Bulaşık Makinesi Parlatıcı 800 ml",
                            ProductCode = "3007975",
                            Quantity = 2
                        },
                        new
                        {
                            Id = 1240,
                            Name = "Finish Classic Jel Bulaşık Makinesi Deterjanı",
                            ProductCode = "11",
                            Quantity = 47
                        },
                        new
                        {
                            Id = 1232,
                            Name = "Fatih 2 pants",
                            ProductCode = "w-l-12532w2i",
                            Quantity = 12
                        },
                        new
                        {
                            Id = 1237,
                            Name = "MAVİ LOGO TİŞÖRT koyu yeşil",
                            ProductCode = "065781-31966",
                            Quantity = -1
                        },
                        new
                        {
                            Id = 1233,
                            Name = "Finish Bulaşık Makinesi Parlatıcı 800 ml",
                            ProductCode = "12321321",
                            Quantity = 51
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
