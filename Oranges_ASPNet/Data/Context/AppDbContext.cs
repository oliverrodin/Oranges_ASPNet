using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Oranges_ASPNet.Data.Enum;
using Oranges_ASPNet.Models;

namespace Oranges_ASPNet.Data.Context
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductStock> ProductStocks { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductCampaign> Campaigns { get; set; }
        public DbSet<Address> Addresses { get; set; }

        //Orders tables
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasData(
                    new Brand
                    {
                        Id = 1, 
                        Name = "Peak Design",
                        LogoUrl = "https://cdn.shopify.com/s/files/1/2986/1172/t/6/assets/headerlogo-10.svg?v=176056868021860541011535753837",
                        Country = "USA",
                        Address = "San Francisco, 2325 3rd St"
                    },
                    new Brand
                    {
                        Id = 2, 
                        Name = "Rimowa",
                        LogoUrl = "https://www.rimowa.com/on/demandware.static/-/Library-Sites-RimowaSharedLibrary/default/dwc27c7ee1/images/rim-logo-footer.svg",
                        Country = "Finland",
                        Address = "Pohjoisesplanadi 31"

                    },
                    new Brand
                    {
                        Id = 3, 
                        Name = "Level 8",
                        LogoUrl = "https://cdn.shopify.com/s/files/1/0029/3404/6831/files/6557dada9ef6da560b32c369936db50d_160x@2x.png?v=1538020561",
                        Country = "USA",
                        Address = "New York 1234"

                    },
                    new Brand
                    {
                        Id = 4, 
                        Name = "Minaal",
                        LogoUrl = "https://cdn.shopify.com/s/files/1/0281/4984/files/minaal-wordmark-logo_140x@2x.png?v=1642373413",
                        Country = "New Zealand",
                        Address = "Beaverton"

                    },
                    new Brand
                    {
                        Id = 5,
                        Name = "Wandrd",
                        LogoUrl = "https://cdn.shopify.com/s/files/1/0051/0368/1570/files/WANDRD_Logo_410x.png?v=1552584995",
                        Country = "USA",
                        Address = "Clinton Street"

                    },
                    new Brand
                    {
                        Id = 6, 
                        Name = "Boundary Supply",
                        LogoUrl = "https://cdn.shopify.com/s/files/1/0104/4630/7364/files/Boundary_Supply_Logo_320x.png?v=1641925041",
                        Country = "USA",
                        Address = "George Town 1"

                    },
                    new Brand 
                    { 
                        Id = 7, 
                        Name = "Alpaka",
                        LogoUrl = "https://storage.googleapis.com/tapcart-150607.appspot.com/12ac4f59f653659f45fac29fbeff088b_AppIconjpg.jpeg",
                        Country = "USA",
                        Address = "425 Smith Street"
                    }
                    );

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
                        BrandId = 1,
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
                        BrandId = 1,
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
                        BrandId = 1,
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
                        BrandId = 1,
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
                        BrandId = 7,
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
                        BrandId = 7,
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
                            "https://cdn.shopify.com/s/files/1/0058/6514/4418/products/TechBrief_0027_14BALL_1000x.jpg?v=1638947444",
                        BrandId = 7,
                        Category = ProductCategory.Backpacks,
                        Model = "Elements tech brief",
                        Description =
                            "An accordion-style organizational opening that provides greater space to store all of your tech essentials neatly.\r\n\r\nSoft-touch, fleece-lined laptop + tablet compartments that provide all-around protection for your devices and quick-access pockets make organization easy. Detachable shoulder strap for multiple carrying options.",
                        Price = 119m,

                    },
                    new Product
                    {
                        Id = 8,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0058/6514/4418/products/BravoMaxPro_0000_HeroDark_1020x1200.jpg?v=1639401857",
                        BrandId = 7,
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
                        BrandId = 3,
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
                        BrandId = 3,
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
                            "https://cdn.shopify.com/s/files/1/0029/3404/6831/products/40_1800x1800.jpg?v=1647427682",
                        BrandId = 3,
                        Category = ProductCategory.Stroller,
                        Model = "Voyageur Check In",
                        Description =
                            "Fit more for less. One of our largest check-in luggage we offer. The Voyageur Luggage is finely crafted in design and functionality to offer a larger capacity for longer trips. We’ve heard your complaints, and we’ve listened. We’ve made a wider handle design to make sure that more of your items can fit. Made with the best Bayer Makrolon material to ensure a lightweight and durable scratch-resistant hard-shell. We’ve enhanced the luggage by adding ultra-quite 360° spinner wheels that feel as smooth as silk when walking to your next gate number.",
                        Price = 299.99m,

                    },
                    new Product
                    {
                        Id = 12,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0029/3404/6831/products/4-2_1800x1800.jpg?v=1652844159",
                        BrandId = 3,
                        Category = ProductCategory.Stroller,
                        Model = "Glitter Carry On",
                        Description =
                            "LEVEL8’s Glitter Carry-on is the latest luggage that comes complete from A to Z with everything you need. This glittering carry-on is expertly crafted with German Makrolon Polycarbonate and further enhanced with ultra-quiet 360° Spinner wheels.  Our goal is to ensure the most deeply satisfying luggage for your adventures by creating an elegantly fashionable, robust, secure, and lightweight piece of luggage that represents your exquisite approach to travel in style.",
                        Price = 269.99m,

                    },
                    new Product
                    {
                        Id = 13,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0051/0368/1570/products/web_prvke_blue_2000x_e9a3b0dc-f040-47e9-8896-232dd98a50de_2000x.jpg?v=1569290940",
                        BrandId = 5,
                        Category = ProductCategory.Backpacks,
                        Model = "Original Prvke",
                        Description =
                            "One of our best-selling and Red Dot award winning luggage. LEVEL8 Gibraltar Aluminum luggage is finely crafted with Aerospace-grade aluminum magnesium alloy. We’ve made sure our products are designed to promote the sense of intelligence, confidence, and maturity along with excellence in functionality.",
                        Price = 194.32m,

                    },
                    new Product
                    {
                        Id = 14,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0051/0368/1570/products/access_green_2000x.png?v=1574986091",
                        BrandId = 5,
                        Category = ProductCategory.Duffel,
                        Model = "Hexad Access Duffel",
                        Description =
                            "The HEXAD Access Duffel Backpack is a carry-on sized backpack/duffel hybrid that features a clamshell opening and is the perfect travel bag, whether you're a photographer or not. Built for 3-5 day trips (and even more depending on how light you pack), this bag is weather resistant, durable, and extremely functional. It been featured in and recommended by Carryology, Bless This Stuff, and Digital Trends.",
                        Price = 301.69m,

                    }, 
                    new Product
                    {
                        Id = 15,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0051/0368/1570/products/carryall_open_blue_2000x.png?v=1609344585",
                        BrandId = 5,
                        Category = ProductCategory.Duffel,
                        Model = "Hexad Carryall Duffel",
                        Description =
                            "The HEXAD Carryall Duffel Backpack is more functional than a traditional duffel, and more versatile than a dedicated travel backpack. From day trips to the slopes to weekend travel, this well thought out backpack/duffel hybrid will adapt to whatever adventure you throw at it. It's extremely weather resistant, durable, and versatile.",
                        Price = 265.15m,

                    },
                    new Product
                    {
                        Id = 16,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0051/0368/1570/products/9LwBlackCase_2000x.png?v=1641941058",
                        BrandId = 5,
                        Category = ProductCategory.Sling,
                        Model = "Roam 9L Sling",
                        Description =
                            "The ROAM 9L Sling is a beautiful and innovative camera-slash-everyday bag built for those that want their cake and want to eat it too. It may look small, but this baby can carry everything you need for a full day of shooting, working, snacking, and all-around butt-kicking. Oh yeah, and it can also fit a 16\" laptop... show us another sling that can do that! We’ll wait. We guarantee that this feature-packed sling is more comfortable than anything else out there. It also features an innovative expandable water bottle/tripod pocket with secure and easy access, removable dividers so you can customize the bag to your needs, and lightning quick access so your gear is always only a moment away. Sling on!",
                        Price = 186.99m,

                    },
                    new Product
                    {
                        Id = 17,
                        ImgUrl =
                            "https://www.rimowa.com/on/demandware.static/-/Sites-rimowa-master-catalog-final/default/dw496544eb/images/large/92563004_2.png",
                        BrandId = 2,
                        Category = ProductCategory.Stroller,
                        Model = "Classic Check-In M",
                        Description =
                            "The unmistakable RIMOWA Original aluminum suitcase with its distinctive grooves is regarded as one of the most iconic luggage designs of all time.\r\n\r\nMade from high-end anodized aluminum, the RIMOWA Original Check-In M in silver is engineered with longevity in mind. Remarkably robust and surprisingly lightweight, this medium sized luggage is an unparalleled example of craftsmanship and innovation and provides the traveler with room for longer journeys of up to 5 days.\r\n\r\nDesigned and engineered in Germany.",
                        Price = 1360m,

                    },
                    new Product
                    {
                        Id = 18,
                        ImgUrl =
                            "https://www.rimowa.com/on/demandware.static/-/Sites-rimowa-master-catalog-final/default/dw0fe65d56/images/large/83273944_2.png",
                        BrandId = 2,
                        Category = ProductCategory.Stroller,
                        Model = "Essential Check-In L",
                        Description =
                            "The first polycarbonate suitcase, designed in Germany to provide the best in high-tech functionality.\r\nStrong, durable, and lightweight, the RIMOWA Essential Check-In L in Bamboo green is the ultimate example of hard shell luggage innovation. Designed to accompany you on a lifetime of journeys, this large check-in suitcase is built to provide room for journeys of up to 10 days.",
                        Price = 925.99m,

                    },
                    new Product
                    {
                        Id = 19,
                        ImgUrl =
                            "https://www.rimowa.com/on/demandware.static/-/Sites-rimowa-master-catalog-final/default/dwcfaa3d95/images/large/88363674_2.png",
                        BrandId = 2,
                        Category = ProductCategory.Stroller,
                        Model = "Hybrid Check-In M",
                        Description =
                            "A thoughtful combination of two of the world’s most advanced materials, the RIMOWA Hybrid Check-In M in all-black unites the resilience of our unique aluminium-magnesium alloy with the supremely lightweight quality of polycarbonate, creating a high-end piece of German engineering designed for a lifetime of purposeful travel.\r\nDesigned and engineered in Germany, this medium-sized suitcase is the ultimate example of luggage innovation and ideal for up to 5 days of travel.",
                        Price = 1040m,

                    },
                    new Product
                    {
                        Id = 20,
                        ImgUrl =
                            "https://www.rimowa.com/on/demandware.static/-/Sites-rimowa-master-catalog-final/default/dw8e169aca/images/large/92540004_2.png",
                        BrandId = 2,
                        Category = ProductCategory.Stroller,
                        Model = "Original Compact",
                        Description =
                            "Cleverly built for both daily commuting and 1 to 2-day trips, the RIMOWA Original Compact in silver provides travelers with the freedom to determine its use.\r\nSimply remove its interior accordion divider to transform it from a wheeled briefcase to a compact carry-on suitcase that fits in most train and aeroplane luggage compartments. Inside, it is equipped with an interior zipped compartment, multiple pockets to organize essentials, and a large padded compartment that holds a laptop up to 16 inches.",
                        Price = 1135m,

                    },
                    new Product
                    {
                        Id = 21,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0104/4630/7364/products/Errant-Pack_X-Pac-Jet-Black_Front_950x.jpg?v=1646766651",
                        BrandId = 7,
                        Category = ProductCategory.Backpacks,
                        Model = "Errant Pack X-Pac",
                        Description =
                            "Boundary's X-Pac material fuses futuristic style with supreme functionality. Errant Pack is an award-winning 22 L modular backpack for everyday use. Technical features and fluid organization enhances your daily rhythm, while the sleek and minimal design seamlessly transitions from the office through the weekend. The core component of an evolving ecosystem of modular accessories, the Errant Pack’s functionality can be customized to your needs, extending the longevity of every product and creating less waste for the planet.",
                        Price = 250m,

                    },
                    new Product
                    {
                        Id = 22,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0104/4630/7364/products/TE-ERS-00107-02_950x.jpg?v=1648485482",
                        BrandId = 7,
                        Category = ProductCategory.Sling,
                        Model = "Errant Sling",
                        Description =
                            "The Errant Sling (formerly known as the Arclite Sling) is built from Stormproof fabrics and zippers to safeguard 15L liters of magnetic compression storage. Constructed to organize and transport your everyday carry essentials; A laptop/tablet compartment is easily accessible through waterproof zippers, so you keep your creative momentum while staying in motion.",
                        Price = 200m,

                    },
                    new Product
                    {
                        Id = 23,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0104/4630/7364/products/Errant-Duffel_Hymassa-Tan_Angle_436ce976-1332-456b-8d93-4a73241a1d00_950x.jpg?v=1638836082",
                        BrandId = 7,
                        Category = ProductCategory.Duffel,
                        Model = "Errant Duffel",
                        Description =
                            "The perfect sidekick for a getaway or trip to the gym, the Errant Duffel (formerly known as the Aegis Duffel) keeps your gear ready and fresh with a ventilated wet/dry compartment. The luggage pass-through, secure quick-access pockets, and carry-on approved size ease your travels, while multiple removable or concealable carry options provide comfort and flexibility. Composed of durable 500D Cordura®, waterproof Hypalon, YKK® StormGuard zippers, and magnetic hardware, this is the ideal duffel for all your on-the-go needs.",
                        Price = 250m,

                    },
                    new Product
                    {
                        Id = 24,
                        ImgUrl =
                            "https://cdn.shopify.com/s/files/1/0104/4630/7364/products/Prima-System_Stone-Grey_System_950x.jpg?v=1634320861",
                        BrandId = 7,
                        Category = ProductCategory.Backpacks,
                        Model = "Prima System",
                        Description =
                            "The Prima System's adaptable storage and modular components make life more comfortable by providing a simple carry solution for your personal, photo, and tech gear. The modular backpack has a large 30 L volume, padded laptop sleeve, and an assortment of pockets to organize gear of all sizes. The included camera case and laptop sleeve can be used individually or with the Prima to expand storage and function when you need it most.",
                        Price = 290m,

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
                    },
                    new ProductStock
                    {
                        Id = 12,
                        ProductId = 12,
                        Quantity = 3
                    },
                    new ProductStock
                    {
                        Id = 13,
                        ProductId = 13,
                        Quantity = 3
                    },
                    new ProductStock
                    {
                        Id = 14,
                        ProductId = 14,
                        Quantity = 3
                    },
                    new ProductStock
                    {
                        Id = 15,
                        ProductId = 15,
                        Quantity = 3
                    },
                    new ProductStock
                    {
                        Id = 16,
                        ProductId = 16,
                        Quantity = 3
                    },
                    new ProductStock
                    {
                        Id = 17,
                        ProductId = 17,
                        Quantity = 4
                    },
                    new ProductStock
                    {
                        Id = 18,
                        ProductId = 18,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 19,
                        ProductId = 19,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 20,
                        ProductId = 20,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 21,
                        ProductId = 21,
                        Quantity = 6
                    },
                    new ProductStock
                    {
                        Id = 22,
                        ProductId = 22,
                        Quantity = 5
                    },
                    new ProductStock
                    {
                        Id = 23,
                        ProductId = 23,
                        Quantity = 7
                    },
                    new ProductStock
                    {
                        Id = 24,
                        ProductId = 24,
                        Quantity = 5
                    }
                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
