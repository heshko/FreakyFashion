using System;
using System.Collections.Generic;
using System.Text;
using FreakyFashion.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreakyFashion.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Name = "Chinos",
                   Description = "Material: 98% bomull, 2% elastan",
                   Price = 200,
                   image = "https://img01.ztat.net/article/PS/72/2E/01/AQ/11/PS722E01A-Q11@10.jpg?imwidth=1800",
                   Type = "trouther",
               },
                new Product
                {
                    Id = 2,
                    Name = "TRAIN LOGO PANT",
                    Description = "Material: Material: 100% polyester",
                    Price = 699,
                    image = "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762",
                    Type = "trouther",
                },
                 new Product
                 {
                     Id = 3,
                     Name = "HYBRID PANT",
                     Description = "Material: Best Byxor",
                     Price = 300,
                     image = "https://img01.ztat.net/article/LE/22/2E/01/9N/11/LE222E019-N11@8.jpg?imwidth=762",
                     Type = "trouther",
                 },
                  new Product
                  {
                      Id = 4,
                      Name = "FLEX WOVEN",
                      Description = "Material: 90% polyester, 10% elastan",
                      Price = 200,
                      image = "https://api.houdinisportswear.com/_images/9a5a6d71-5f4e-4eb2-84ff-87ea785e3c09/MsJoPants_P_BaremarkGreen_S.jpg",
                      Type = "trouther",
                  },
                   new Product
                   {
                       Id = 5,
                       Name = "TAPE PANTS",
                       Description = "Material: 79% bomull, 21% polyester",
                       Price = 700,
                       image = "https://www.verywellfit.com/thmb/11wnypV38gPbWQYjKqkhmdGc1LY=/640x640/smart/filters:no_upscale()/IntentJogger30-5a68b0b243a103001afe7475.jpeg",
                       Type = "trouther",
                   },
                    new Product
                    {
                        Id = 6,
                        Name = "Tygbyxor",
                        Description = "Material: 100% bomull",
                        Price = 400,
                        image = "https://revolutionrace.imgix.net/6119-large_default/twisted-outdoor-jeans-mens-anthracite.jpg",
                        Type = "trouther",
                    },
                     new Product
                     {
                         Id = 7,
                         Name = "Tygbyxor",
                         Description = "Material: 84% polyester, 15% viskos, 1% elastan",
                         Price = 200,
                         image = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oqd1pzehuh6pqdsjtoy4/sportswear-tech-fleece-trousers-vWH3lg.jpg",
                         Type = "trouther",
                     },
                      new Product
                      {
                          Id = 8,
                          Name = "Tygbyxor",
                          Description = "Material: 97% bomull, 3% elastanr",
                          Price = 200,
                          image = "https://imgcdn.carhartt.com/is/image/Carhartt/B324ARG?$400L2$",
                          Type = "trouther",
                      },
                      new Product
                      {
                          Id = 9,
                          Name = "Piké",
                          Description = "Material: 100% bomull",
                          Price = 700,
                          image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560808195-fila-1560808184.jpg",
                          Type = "shirts",
                      },
                        new Product
                        {
                            Id = 10,
                            Name = "FLORAL PANEL - Piké",
                            Description = "Material: 100% bomull",
                            Price = 100,
                            image = "https://cdni.llbean.net/is/image/wim/224547_36814_41?hei=1095&wid=950&resMode=sharp2&defaultImage=llbstage/A0211793_2",
                            Type = "shirts",
                        },
                          new Product
                          {
                              Id = 11,
                              Name = "CHECK - Piké",
                              Description = "Material: 100% bomull",
                              Price = 190,
                              image = "https://www.all4o.com/image/cache/data/brand/TrueStory/TRUE-STORY-Elite-orienteering-shirt-Men-Deep-BLUE-800x800.jpg",
                              Type = "shirts",
                          },
                            new Product
                            {
                                Id = 12,
                                Name = "Sweatshirt",
                                Description = "Material: 60% bomull, 40% polyester",
                                Price = 200,
                                image = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Champion-Boys-Logo-Dip-Dyed-Sunny-Yellow-T-Shirt--_308437.jpg",
                                Type = "shirts",
                            },
                              new Product
                              {
                                  Id = 13,
                                  Name = "Piké",
                                  Description = "Material: 100% bomull",
                                  Price = 400,
                                  image = "https://images.www.fendi.com/images/h07/h2b/8971945836574/FS7255A5XSF0GME_01_medium",
                                  Type = "shirts",
                              },
                                new Product
                                {
                                    Id = 14,
                                    Name = "BASIC 2 PACK - Piké",
                                    Description = "Material: 100% bomull",
                                    Price = 700,
                                    image = "https://prochoice.org/wp-content/uploads/t-shirt_transparent-234x300.png",
                                    Type = "shirts",
                                },
                                  new Product
                                  {
                                      Id = 15,
                                      Name = "GEO ALL - Piké",
                                      Description = "Material: 100% bomull",
                                      Price = 200,
                                      image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1558112729-frame-chloe-king-1558112717.jpg",
                                      Type = "shirts",
                                  },
                                   new Product
                                   {
                                       Id = 16,
                                       Name = "CAMBRIDGE - Piké",
                                       Description = "MATERIAL & SKÖTSEL",
                                       Price = 300,
                                       image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSpHudtzLUfAXABtMXmcO0Kyvuru1fOfa25N8ZgjGgzSC29CdaN",
                                       Type = "shirts",
                                   },
                                   new Product
                                   {
                                       Id = 17,
                                       Name = "TAMAYO DRESS",
                                       Description = "Material: 100% viskos",
                                       Price = 900,
                                       image = "https://cdn.shopify.com/s/files/1/2714/9310/products/Unique_Vintage_1950s_Black_Embroidered_Red_Rose_Baltimore_Swing_Dress_1024x1024.jpg?v=1571711475",
                                       Type = "dress",
                                   },
                                    new Product
                                    {
                                        Id = 18,
                                        Name = "MNIA DRESS",
                                        Description = "Material: 100% viskos",
                                        Price = 200,
                                        image = "https://photo.venus.com/im/18062700.jpg?preset=product",
                                        Type = "dress",
                                    },
                                     new Product
                                     {
                                         Id = 19,
                                         Name = "GILLEA - Skjortklänning",
                                         Description = "Material: 100% viskos",
                                         Price = 1200,
                                         image = "https://is4.revolveassets.com/images/p4/n/c/AXIS-WD409_V1.jpg",
                                         Type = "dress",
                                     },
                                      new Product
                                      {
                                          Id = 20,
                                          Name = "VALENTINA DRESS - Skjortklänning",
                                          Description = "Material: 100% polyester",
                                          Price = 400,
                                          image = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=",
                                          Type = "dress",
                                      },
                                        new Product
                                      {
                                            Id = 21,
                                            Name = "AMARIS LONG KIMONO",
                                            Description = "Material: 100% polyester",
                                            Price = 400,
                                            image = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=",
                                            Type = "dress",
                                       },
                                        new Product
                                       {
                                              Id = 22,
                                              Name = "CETO DRAWSTRING",
                                              Description = "Material: 100% polyester",
                                              Price = 400,
                                              image = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=",
                                              Type = "dress",
                                        },
                                        new Product
                                        {
                                            Id = 23,
                                            Name = "NINGBOX - Skjortklänning",
                                            Description = "Material: 100% viskos",
                                            Price = 400,
                                            image = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=",
                                            Type = "dress",
                                        },
                                        new Product
                                        {
                                            Id = 24,
                                            Name = "PCNICOLETTA DRESS - Skjortklänning",
                                            Description = "Material: 100% viskos",
                                            Price = 400,
                                            image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSJcssYg9A7u-6EBTode1IUBygxPnO1gk6GvyzzsT7ze3mBS2U-",
                                            Type = "dress",
                                        }
               ); ;
        }
    }
}
