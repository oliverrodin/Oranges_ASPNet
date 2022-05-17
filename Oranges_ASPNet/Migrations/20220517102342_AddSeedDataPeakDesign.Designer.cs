﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oranges_ASPNet.Data.Context;

#nullable disable

namespace Oranges_ASPNet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220517102342_AddSeedDataPeakDesign")]
    partial class AddSeedDataPeakDesign
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Oranges_ASPNet.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Brand")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = 1,
                            Category = 2,
                            Description = "An iconic, award-winning pack for everyday and photo carry, the newly revamped Everyday Backpack is built around access, organization, expansion, and protection. Unique MagLatch hardware provides lightning fast top access, with dual side access via two weatherproof UltraZips.",
                            ImgUrl = "https://cdn.shopify.com/s/files/1/2986/1172/products/black-edb20_1024x1024.jpg?v=1595964079",
                            Model = "Everyday Backpack",
                            Price = 279.95m
                        },
                        new
                        {
                            Id = 2,
                            Brand = 1,
                            Category = 1,
                            Description = "The all-new Everyday Messenger is the latest rev of our original award-winning everyday and photo carry workhorse—the bag that we designed with renowned photographer Trey Ratcliff and honed with the feedback of thousands of customers.",
                            ImgUrl = "https://cdn.shopify.com/s/files/1/2986/1172/products/black-EDMbl01_1024x1024.jpg?v=1574661040",
                            Model = "Everyday Messenger",
                            Price = 229.95m
                        },
                        new
                        {
                            Id = 3,
                            Brand = 1,
                            Category = 3,
                            Description = "The 65L Duffel is a monster gear-hauler, ruggedly dependable for airline check-in and road trips. Both bags feature removable padded top handles, a removable padded shoulder strap, 2 internal mesh pockets, and 4 external side pockets for added organization.",
                            ImgUrl = "https://cdn.shopify.com/s/files/1/2986/1172/products/1-PDP-Lightbox-Duffel65-BLACK-01-edit_1024x1024.jpg?v=1644352278",
                            Model = "Travel Duffel",
                            Price = 169.95m
                        },
                        new
                        {
                            Id = 4,
                            Brand = 1,
                            Category = 2,
                            Description = "The smaller sibling of our iconic 45L Travel Backpack, the 30L is a rugged, expandable daypack ideal for shorter travel and everyday carry. A big, beautiful rear hatch provides total access for easy packing and unpacking.",
                            ImgUrl = "https://cdn.shopify.com/s/files/1/2986/1172/products/1-LIGHTBOX-1024x1024-TRBP-BLACK-02_6db62b4c-ff89-4612-9c69-e033a00897c5_1024x1024.jpg?v=1643233483",
                            Model = "Travel Backpack 30L",
                            Price = 229.95m
                        });
                });

            modelBuilder.Entity("Oranges_ASPNet.Models.ProductStock", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductStocks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductId = 1,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 2,
                            ProductId = 2,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 3,
                            ProductId = 3,
                            Quantity = 5
                        },
                        new
                        {
                            Id = 4,
                            ProductId = 4,
                            Quantity = 5
                        });
                });

            modelBuilder.Entity("Oranges_ASPNet.Models.ProductStock", b =>
                {
                    b.HasOne("Oranges_ASPNet.Models.Product", "Product")
                        .WithOne("Stock")
                        .HasForeignKey("Oranges_ASPNet.Models.ProductStock", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Oranges_ASPNet.Models.Product", b =>
                {
                    b.Navigation("Stock")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
