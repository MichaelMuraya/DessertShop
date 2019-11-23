﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperbRecipe.Models;

namespace SuperbRecipe.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            CategoryName = "Coffee"
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
                            CategoryName = "Cheese Cakes"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Ice-Cream"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Offers"
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
                            DessertId = 7,
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
                            DessertId = 10,
                            AllergyInformation = "Might have Soya",
                            CategoryId = 2,
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
                            DessertId = 3,
                            AllergyInformation = "Has Wheat and milk products",
                            CategoryId = 5,
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
                            DessertId = 5,
                            AllergyInformation = "Has berries and milk products",
                            CategoryId = 5,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg",
                            ImageUrl = "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg",
                            InStock = true,
                            LongDescription = "The best Cheese Cake in this part of the world!!",
                            Name = "Blueberry Cheese Cake",
                            Price = 15.35m,
                            ShortDescription = "Tasty as Mummy made it!!"
                        },
                        new
                        {
                            DessertId = 11,
                            AllergyInformation = "Has nuts and milk products",
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
                            DessertId = 2,
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
                        },
                        new
                        {
                            DessertId = 8,
                            AllergyInformation = "Has nuts and milk products",
                            CategoryId = 5,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg",
                            ImageUrl = "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg",
                            InStock = true,
                            LongDescription = "The latest Chocolate Cheese cake in our selection!!",
                            Name = "Chocolate Cheese Cake",
                            Price = 10.50m,
                            ShortDescription = "New recipe!!"
                        },
                        new
                        {
                            DessertId = 4,
                            AllergyInformation = "Has nuts,milk products and Soy",
                            CategoryId = 6,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s",
                            ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s",
                            InStock = true,
                            LongDescription = "The Ice-cream of your choice!!",
                            Name = "Chocolate Icecream",
                            Notes = "Best served chilled",
                            Price = 7.25m,
                            ShortDescription = "The Only handmade Icecream in town!!"
                        },
                        new
                        {
                            DessertId = 1,
                            AllergyInformation = "Has nuts,milk products and Soy",
                            CategoryId = 7,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg",
                            ImageUrl = "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg",
                            InStock = true,
                            LongDescription = "The Ice-cream of your choice!!",
                            Name = "Ice-cream mix",
                            Notes = "Best served chilled",
                            Price = 20.25m,
                            ShortDescription = "The Only handmade Icecream in town!!"
                        },
                        new
                        {
                            DessertId = 12,
                            AllergyInformation = "Has nuts,milk products and Soy",
                            CategoryId = 6,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg",
                            ImageUrl = "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg",
                            InStock = true,
                            LongDescription = "The Ice-cream of your choice!!",
                            Name = "Caramel Ice-cream mix",
                            Notes = "Best served chilled",
                            Price = 9.25m,
                            ShortDescription = "The Only handmade Icecream in town!!"
                        },
                        new
                        {
                            DessertId = 9,
                            AllergyInformation = "Has nuts,milk products and Soy",
                            CategoryId = 3,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg",
                            ImageUrl = "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg",
                            InStock = true,
                            LongDescription = "The Ice-cream of your choice!!",
                            Name = "Spinach-mushroom pie",
                            Notes = "Best served warm",
                            Price = 11.25m,
                            ShortDescription = "The Only handmade Icecream in town!!"
                        },
                        new
                        {
                            DessertId = 6,
                            AllergyInformation = "Has nuts,milk products and Soy",
                            CategoryId = 3,
                            DessertofWeek = true,
                            ImageThumbnailUrl = "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg",
                            ImageUrl = "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg",
                            InStock = true,
                            LongDescription = "THe strawberries make it all worth it!!",
                            Name = "Strawberry Pie",
                            Notes = "Best served warm with milk",
                            Price = 7.25m,
                            ShortDescription = "Freshly picked Strawberries!!"
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

                    b.Property<int>("DessertId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("DessertId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("SuperbRecipe.Models.SendOrder", b =>
                {
                    b.Property<int>("SendOrderId")
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

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("SendersName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SendOrderId");

                    b.ToTable("SendOrders");
                });

            modelBuilder.Entity("SuperbRecipe.Models.SendOrderDetail", b =>
                {
                    b.Property<int>("SendOrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("DessertId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SendOrderId")
                        .HasColumnType("int");

                    b.HasKey("SendOrderDetailId");

                    b.HasIndex("DessertId");

                    b.HasIndex("SendOrderId");

                    b.ToTable("SendOrderDetails");
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
                        .HasForeignKey("DessertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SuperbRecipe.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SuperbRecipe.Models.SendOrderDetail", b =>
                {
                    b.HasOne("SuperbRecipe.Models.Dessert", "Dessert")
                        .WithMany()
                        .HasForeignKey("DessertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SuperbRecipe.Models.SendOrder", "SendOrder")
                        .WithMany("SendOrderDetails")
                        .HasForeignKey("SendOrderId")
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
