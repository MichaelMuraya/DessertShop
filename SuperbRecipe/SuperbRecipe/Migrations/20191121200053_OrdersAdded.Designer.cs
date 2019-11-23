﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperbRecipe.Models;

namespace SuperbRecipe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191121200053_OrdersAdded")]
    partial class OrdersAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuperbRecipe.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruit pies"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Cheese cakes"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Seasonal pies"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Smoothies"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Coffee"
                        });
                });

            modelBuilder.Entity("SuperbRecipe.Models.Dessert", b =>
                {
                    b.Property<int>("DessertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("DessertofWeek")
                        .HasColumnType("bit");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DessertId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Desserts");

                    b.HasData(
                        new
                        {
                            DessertId = 1,
                            AllergyInformation = "Has nuts",
                            CategoryId = 1,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s",
                            InStock = true,
                            LongDescription = "The Pies reimd you of Christmas in Lapland!!",
                            Name = "Apple Pie",
                            Notes = "Put two spoonfuls of sugar in a a bowl",
                            Price = 12.35m,
                            ShortDescription = "The Best Apple Pies in Town!!"
                        },
                        new
                        {
                            DessertId = 2,
                            AllergyInformation = "",
                            CategoryId = 2,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg",
                            ImageUrl = "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg",
                            InStock = true,
                            LongDescription = "The best Cheese Cake in this part of the world!!",
                            Name = "Lemon Cheese Cake",
                            Price = 14.25m,
                            ShortDescription = "Tasty as Mummy made it!!"
                        },
                        new
                        {
                            DessertId = 3,
                            AllergyInformation = "",
                            CategoryId = 3,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg",
                            ImageUrl = "C:\\Users\\35840\\Desktop\\SuperbRecipe\\SuperbRecipe\\SuperbRecipe\\wwwroot\\Delish\\blueberry1.jpg",
                            InStock = true,
                            LongDescription = "The best Cheese Cake in this part of the world!!",
                            Name = "Blueberry Cheese Cake",
                            Price = 15.35m,
                            ShortDescription = "Tasty as Mummy made it!!"
                        },
                        new
                        {
                            DessertId = 4,
                            AllergyInformation = "",
                            CategoryId = 4,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s",
                            InStock = true,
                            LongDescription = "Get your Vitamins on the go!!",
                            Name = "Smoothies",
                            Price = 10.15m,
                            ShortDescription = "Refreshing!!"
                        },
                        new
                        {
                            DessertId = 5,
                            AllergyInformation = "Might have Soya",
                            CategoryId = 5,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG",
                            InStock = true,
                            LongDescription = "The best Coffee in this part of the world!!",
                            Name = "Black Coffee",
                            Price = 3.25m,
                            ShortDescription = "From the best Hills of Peru!!"
                        },
                        new
                        {
                            DessertId = 6,
                            AllergyInformation = "Has nuts",
                            CategoryId = 1,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s",
                            InStock = true,
                            LongDescription = "The latest Apple Pie in our selection!!",
                            Name = "Apple Pie",
                            Price = 10.35m,
                            ShortDescription = "New recipe!!"
                        });
                });

            modelBuilder.Entity("SuperbRecipe.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("SuperbRecipe.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("DessertId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("PieId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("DessertId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("SuperbRecipe.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("DessertId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("DessertId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("SuperbRecipe.Models.Dessert", b =>
                {
                    b.HasOne("SuperbRecipe.Models.Category", "Category")
                        .WithMany("Dessert")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperbRecipe.Models.OrderDetail", b =>
                {
                    b.HasOne("SuperbRecipe.Models.Dessert", "Dessert")
                        .WithMany()
                        .HasForeignKey("DessertId");

                    b.HasOne("SuperbRecipe.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperbRecipe.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("SuperbRecipe.Models.Dessert", "Dessert")
                        .WithMany()
                        .HasForeignKey("DessertId");
                });
#pragma warning restore 612, 618
        }
    }
}
