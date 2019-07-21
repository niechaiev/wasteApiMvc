﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations
{
    [DbContext(typeof(ModelsContext))]
    [Migration("20190520234659_cardwasteid")]
    partial class cardwasteid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.Bill", b =>
                {
                    b.Property<int>("BillId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardId");

                    b.Property<DateTime>("DateTime");

                    b.HasKey("BillId");

                    b.HasIndex("CardId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("WebAPI.Models.BillProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("BillId");

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ProductId");

                    b.ToTable("BillProducts");
                });

            modelBuilder.Entity("WebAPI.Models.BillProductWaste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BillProductId");

                    b.Property<double>("DiscountedAmount");

                    b.Property<int>("WasteId");

                    b.HasKey("Id");

                    b.HasIndex("BillProductId");

                    b.HasIndex("WasteId");

                    b.ToTable("BillProductWastes");
                });

            modelBuilder.Entity("WebAPI.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardOwnerName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email");

                    b.Property<string>("PasswordHash");

                    b.HasKey("CardId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("WebAPI.Models.CardWaste", b =>
                {
                    b.Property<int>("CardWasteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("CardId");

                    b.Property<int>("WasteId");

                    b.HasKey("CardWasteId");

                    b.HasIndex("CardId");

                    b.HasIndex("WasteId");

                    b.ToTable("CardWastes");
                });

            modelBuilder.Entity("WebAPI.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("BasePrice");

                    b.Property<bool>("IsSoldByWeight");

                    b.Property<string>("Name");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebAPI.Models.ProductWaste", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("ProductId");

                    b.Property<int>("WasteId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("WasteId");

                    b.ToTable("ProductWastes");
                });

            modelBuilder.Entity("WebAPI.Models.Waste", b =>
                {
                    b.Property<int>("WasteId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<double>("RecyclingPrice");

                    b.Property<double>("StartAmount");

                    b.HasKey("WasteId");

                    b.ToTable("Wastes");
                });

            modelBuilder.Entity("WebAPI.Models.Bill", b =>
                {
                    b.HasOne("WebAPI.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models.BillProduct", b =>
                {
                    b.HasOne("WebAPI.Models.Bill", "Bill")
                        .WithMany()
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models.BillProductWaste", b =>
                {
                    b.HasOne("WebAPI.Models.BillProduct", "BillProduct")
                        .WithMany()
                        .HasForeignKey("BillProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models.Waste", "Waste")
                        .WithMany()
                        .HasForeignKey("WasteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models.CardWaste", b =>
                {
                    b.HasOne("WebAPI.Models.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models.Waste", "Waste")
                        .WithMany()
                        .HasForeignKey("WasteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebAPI.Models.ProductWaste", b =>
                {
                    b.HasOne("WebAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebAPI.Models.Waste", "Waste")
                        .WithMany()
                        .HasForeignKey("WasteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
