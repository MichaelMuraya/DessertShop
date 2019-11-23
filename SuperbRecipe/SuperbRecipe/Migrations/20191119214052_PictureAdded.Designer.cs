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
    [Migration("20191119214052_PictureAdded")]
    partial class PictureAdded
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

                    b.Property<decimal?>("Price")
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
                            AllergyInformation = "",
                            CategoryId = 1,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxiyuVFw8XkdS6iKbDo0W9jiUwKiZ64BNDVlb9sO7pN4b1cPPRBw&s",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxiyuVFw8XkdS6iKbDo0W9jiUwKiZ64BNDVlb9sO7pN4b1cPPRBw&s",
                            InStock = true,
                            LongDescription = "The best Apple pie in town reminds you of Christmas in Lapland!!",
                            Name = "Apple Pie",
                            Price = 12.35m,
                            ShortDescription = "Awesome pies!!"
                        },
                        new
                        {
                            DessertId = 2,
                            AllergyInformation = "",
                            CategoryId = 1,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg",
                            ImageUrl = "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg",
                            InStock = true,
                            LongDescription = "The best Cheese Cake in this part of the world!!",
                            Name = "Lemon Cheese Cake",
                            ShortDescription = "Tasty as Mummy made it!!"
                        },
                        new
                        {
                            DessertId = 3,
                            AllergyInformation = "",
                            CategoryId = 1,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://www.simplyrecipes.com/wp-content/uploads/2005/07/blueberry-cake-vertical-b-1200-768x1152.jpg",
                            ImageUrl = "https://www.simplyrecipes.com/wp-content/uploads/2005/07/blueberry-cake-vertical-b-1200-768x1152.jpg",
                            InStock = true,
                            LongDescription = "The best Cheese Cake in this part of the world!!",
                            Name = "Blueberry Cheese Cake",
                            ShortDescription = "Tasty as Mummy made it!!"
                        });
                });

            modelBuilder.Entity("SuperbRecipe.Models.Dessert", b =>
                {
                    b.HasOne("SuperbRecipe.Models.Category", "Category")
                        .WithMany("Dessert")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
