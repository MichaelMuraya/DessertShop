using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperbRecipe.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
        {
        }

        public virtual DbSet<Dessert> Desserts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<SendOrderDetail> SendOrderDetails { get; set; }
        public virtual DbSet<SendOrder> SendOrders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Coffee" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Seasonal pies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Smoothies" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Cheese Cakes" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 6, CategoryName = "Ice-Cream" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 7, CategoryName = "Offers" });

            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 7,
                Name = "Apple Pie",
                Price = 12.35M,
                ShortDescription = "The Best Apple Pies in Town!!",
                LongDescription = "The Pies reimd you of Christmas in Lapland!!",
                CategoryId = 1,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRmLWlSefb8vZKA0iFQzLXkPCEpg2UL0Lt4JylQBRoUBvsc-d8N&s",
                AllergyInformation = "Has nuts",
                Notes="Put two spoonfuls of sugar in a a bowl"


            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {

                DessertId = 10,
                Name = "Black Coffee",
                Price = 3.25M,
                ShortDescription = "From the best Hills of Peru!!",
                LongDescription = "The best Coffee in this part of the world!!",
                CategoryId = 2,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/4/45/A_small_cup_of_coffee.JPG",
                AllergyInformation = "Might have Soya"
            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {

                DessertId = 3,
                Name = "Lemon Cheese Cake",
                Price = 14.25M,
                ShortDescription = "Tasty as Mummy made it!!",
                LongDescription = "The best Cheese Cake in this part of the world!!",
                CategoryId = 5,
                ImageUrl = "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://www.handletheheat.com/wp-content/uploads/2019/07/Lemon-Cheesecake-SQUARE.jpg",
                AllergyInformation = "Has Wheat and milk products"
            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 5,
                Name = "Blueberry Cheese Cake",
                Price = 15.35M,
                ShortDescription = "Tasty as Mummy made it!!",
                LongDescription = "The best Cheese Cake in this part of the world!!",
                CategoryId = 5,
                ImageUrl = "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://sugargeekshow.com/wp-content/uploads/2019/05/lemon-blueberry-cake-featured.jpg",
                AllergyInformation = "Has berries and milk products"
            }); ; ;
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 11,
                Name = "Smoothies",
                Price = 10.15M,
                ShortDescription = "Refreshing!!",
                LongDescription = "Get your Vitamins on the go!!",
                CategoryId = 4,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQOfcvrFzYKIG8vjeSMmPPqw3iMSCyAQl9GcrA8DOYS1KvXOV08Uw&s",
                AllergyInformation = "Has nuts and milk products"
            });
            
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 2,
                Name = "Apple Pie",
                Price = 10.35M,
                ShortDescription = "New recipe!!",
                LongDescription = "The latest Apple Pie in our selection!!",
                CategoryId = 1,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJcrw2yrDOv-NeBY1LbCJUFCk6mrzAb9YrbKHpJwO_7TPi0D3-7w&s",
                AllergyInformation = "Has nuts"



            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 8,
                Name = "Chocolate Cheese Cake",
                Price = 10.50M,
                ShortDescription = "New recipe!!",
                LongDescription = "The latest Chocolate Cheese cake in our selection!!",
                CategoryId = 5,
                ImageUrl = "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://cdn.pixabay.com/photo/2017/01/11/11/33/cake-1971552_1280.jpg",
                AllergyInformation = "Has nuts and milk products"



            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 4,
                Name = "Chocolate Icecream",
                Price = 7.25M,
                ShortDescription = "The Only handmade Icecream in town!!",
                LongDescription = "The Ice-cream of your choice!!",
                CategoryId = 6,
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRsBEgwob8e4fUE0fWWA8iM_3hpLAtCA--QREP54h5Y62apcmhO&s",
                AllergyInformation = "Has nuts,milk products and Soy",
                Notes = "Best served chilled"


            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 1,
                Name = "Ice-cream mix",
                Price = 20.25M,
                ShortDescription = "The Only handmade Icecream in town!!",
                LongDescription = "The Ice-cream of your choice!!",
                CategoryId = 7,
                ImageUrl = "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://img.buzzfeed.com/video-api-prod/assets/e1388f70d9d34394a0b9cfabe3f1bae7/BFV21242_Ice_Cream_4_Ways_FB_THUMB.jpg",
                AllergyInformation = "Has nuts,milk products and Soy",
                Notes = "Best served chilled"


            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 12,
                Name = "Caramel Ice-cream mix",
                Price = 9.25M,
                ShortDescription = "The Only handmade Icecream in town!!",
                LongDescription = "The Ice-cream of your choice!!",
                CategoryId = 6,
                ImageUrl = "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://www.loveandoliveoil.com/wp-content/uploads/2016/09/caramel-cookie-ice-creamH2-1200x550.jpg",
                AllergyInformation = "Has nuts,milk products and Soy",
                Notes = "Best served chilled"


            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 9,
                Name = "Spinach-mushroom pie",
                Price = 11.25M,
                ShortDescription = "The Only handmade Icecream in town!!",
                LongDescription = "The Ice-cream of your choice!!",
                CategoryId = 3,
                ImageUrl = "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://www.bbcgoodfood.com/sites/default/files/recipe-collections/collection-image/2013/05/chicken-kale-mushroom-pot-pie.jpg",
                AllergyInformation = "Has nuts,milk products and Soy",
                Notes = "Best served warm"


            });
            modelBuilder.Entity<Dessert>().HasData(new Dessert
            {
                DessertId = 6,
                Name = "Strawberry Pie",
                Price = 7.25M,
                ShortDescription = "Freshly picked Strawberries!!",
                LongDescription = "THe strawberries make it all worth it!!",
                CategoryId = 3,
                ImageUrl = "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg",
                InStock = true,
                DessertofWeek = true,
                ImageThumbnailUrl = "https://www.tasteofhome.com/wp-content/uploads/2018/01/Easy-Fresh-Strawberry-Pie_EXPS_TMBBP19_34179_B06_20_3b.jpg",
                AllergyInformation = "Has nuts,milk products and Soy",
                Notes = "Best served warm with milk"


            });
            
        }
    }
}
