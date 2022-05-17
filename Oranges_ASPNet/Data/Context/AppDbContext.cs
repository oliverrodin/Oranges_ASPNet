using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Enum;
using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(a => a.Stock)
                .WithOne(b => b.Product)
                .HasForeignKey<ProductStock>(b => b.ProductId);


            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = 1,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/2986/1172/products/black-edb20_1024x1024.jpg?v=1595964079",
                        Brand = ProductBrand.PeakDesign,
                        Category = ProductCategory.Backpacks,
                        Model = "Everyday Backpack",
                        Description =
                            "An iconic, award-winning pack for everyday and photo carry, the newly revamped Everyday Backpack is built around access, organization, expansion, and protection. Unique MagLatch hardware provides lightning fast top access, with dual side access via two weatherproof UltraZips.",
                        Price = 279.95m,

                    },
                    new Product
                    {
                        Id = 2,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/2986/1172/products/black-EDMbl01_1024x1024.jpg?v=1574661040",
                        Brand = ProductBrand.PeakDesign,
                        Category = ProductCategory.Messenger,
                        Model = "Everyday Messenger",
                        Description =
                            "The all-new Everyday Messenger is the latest rev of our original award-winning everyday and photo carry workhorse—the bag that we designed with renowned photographer Trey Ratcliff and honed with the feedback of thousands of customers.",
                        Price = 229.95m,

                    },
                    new Product
                    {
                        Id = 3,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/2986/1172/products/1-PDP-Lightbox-Duffel65-BLACK-01-edit_1024x1024.jpg?v=1644352278",
                        Brand = ProductBrand.PeakDesign,
                        Category = ProductCategory.Duffel,
                        Model = "Travel Duffel",
                        Description =
                            "The 65L Duffel is a monster gear-hauler, ruggedly dependable for airline check-in and road trips. Both bags feature removable padded top handles, a removable padded shoulder strap, 2 internal mesh pockets, and 4 external side pockets for added organization.",
                        Price = 169.95m,

                    },
                    new Product
                    {
                        Id = 4,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/2986/1172/products/1-LIGHTBOX-1024x1024-TRBP-BLACK-02_6db62b4c-ff89-4612-9c69-e033a00897c5_1024x1024.jpg?v=1643233483",
                        Brand = ProductBrand.PeakDesign,
                        Category = ProductCategory.Backpacks,
                        Model = "Travel Backpack 30L",
                        Description =
                            "The smaller sibling of our iconic 45L Travel Backpack, the 30L is a rugged, expandable daypack ideal for shorter travel and everyday carry. A big, beautiful rear hatch provides total access for easy packing and unpacking.",
                        Price = 229.95m,

                    },
                    new Product
                    {
                        Id = 5,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0058/6514/4418/products/alpha-hero_1020x1200.jpg?v=1636031359",
                        Brand = ProductBrand.Alpaka,
                        Category = ProductCategory.Messenger,
                        Model = "Alpha Messenger",
                        Description =
                            "This sleek and modern messenger bag is perfect for your daily journeys. It features premium craftsmanship, world-class organizational compartments and weatherproof construction that's ready to take on anything.",
                        Price = 144.95m,

                    },
                    new Product
                    {
                        Id = 6,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0058/6514/4418/products/elements-backpack-hero2_1020x1200.jpg?v=1633353165",
                        Brand = ProductBrand.Alpaka,
                        Category = ProductCategory.Backpacks,
                        Model = "Elements Backpack",
                        Description =
                            "The Elements Backpack is designed with organization in mind: pockets for laptop and tablet space, deep zips to hide things away - the perfect choice whether you're commuting or just grabbing coffee.",
                        Price = 229.95m,

                    },
                    new Product
                    {
                        Id = 7,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/2986/1172/products/1-LIGHTBOX-1024x1024-TRBP-BLACK-02_6db62b4c-ff89-4612-9c69-e033a00897c5_1024x1024.jpg?v=1643233483",
                        Brand = ProductBrand.Alpaka,
                        Category = ProductCategory.Backpacks,
                        Model = "Travel Backpack 30L",
                        Description =
                            "The smaller sibling of our iconic 45L Travel Backpack, the 30L is a rugged, expandable daypack ideal for shorter travel and everyday carry. A big, beautiful rear hatch provides total access for easy packing and unpacking.",
                        Price = 154.95m,

                    },
                    new Product
                    {
                        Id = 8,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0058/6514/4418/products/BravoMaxPro_0000_HeroDark_1020x1200.jpg?v=1639401857",
                        Brand = ProductBrand.Alpaka,
                        Category = ProductCategory.Sling,
                        Model = "Bravo Sling Max (PRO)",
                        Description =
                            "Make the most of every day with Bravo Sling Max (Pro), a slashproof messenger-style sling bag that you can take anywhere. It comes equipped with an adjustable shoulder strap for maximum comfort/minimal stress and a self-locking magnetic buckle - for extra peace of mind.",
                        Price = 135.95m,

                    },
                    new Product
                    {
                        Id = 9,
                        ImgUrl =
                                "https://cdn.shopify.com/s/files/1/0029/3404/6831/products/2_1800x1800.jpg?v=1644919395",
                        Brand = ProductBrand.LevelEight,
                        Category = ProductCategory.Stroller,
                        Model = "Pro Carry-On With Laptop Pocket 20",
                        Description =
                                "LEVEL8’s Pro Carry-on with Laptop Pocket is another one of our Red Dot award winning luggage. Finely crafted with aerospace-grade Bayer Makrolon. We’ve designed this luggage to be water-resistant, lightweight, and have a durable hard-shell casing to protect your most expensive items. We’ve combined the sense of confidence, intelligence, and sophistication to complement its excellence in functionality. Enhanced with ultra-quite 360° spinner wheels that can handle the cobblestone streets of Europe and ensure a delightful walk to your airport gate number.",
                        Price = 209.95m,

                    },
                    new Product
                    {
                        Id = 10,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0029/3404/6831/products/aluminumsilver_fd88d170-88cc-4ba1-a35c-ac8f4a47c47b_1800x1800.jpg?v=1606816036",
                        Brand = ProductBrand.LevelEight,
                        Category = ProductCategory.Stroller,
                        Model = "Full Aluminium Carry-On 20",
                        Description =
                            "One of our best-selling and Red Dot award winning luggage. LEVEL8 Gibraltar Aluminum luggage is finely crafted with Aerospace-grade aluminum magnesium alloy. We’ve made sure our products are designed to promote the sense of intelligence, confidence, and maturity along with excellence in functionality.",
                        Price = 399.95m,

                    },
                    new Product
                    {
                        Id = 11,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0051/0368/1570/products/web_prvke_blue_2000x_e9a3b0dc-f040-47e9-8896-232dd98a50de_2000x.jpg?v=1569290940",
                        Brand = ProductBrand.Wandrd,
                        Category = ProductCategory.Backpacks,
                        Model = "Original Prvke",
                        Description =
                            "One of our best-selling and Red Dot award winning luggage. LEVEL8 Gibraltar Aluminum luggage is finely crafted with Aerospace-grade aluminum magnesium alloy. We’ve made sure our products are designed to promote the sense of intelligence, confidence, and maturity along with excellence in functionality.",
                        Price = 194.32m,

                    }
                );

            modelBuilder.Entity<ProductStock>()
                .HasData(
                    new ProductStock
                    {
                        Id = 1,
                        ProductId = 1,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 2,
                        ProductId = 2,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 3,
                        ProductId = 3,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 4,
                        ProductId = 4,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 5,
                        ProductId = 5,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 6,
                        ProductId = 6,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 7,
                        ProductId = 7,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 8,
                        ProductId = 8,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 9,
                        ProductId = 9,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 10,
                        ProductId = 10,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 11,
                        ProductId = 11,
                        Quantity = 5
                    }


                    );


            base.OnModelCreating(modelBuilder);
        }
    }
}
