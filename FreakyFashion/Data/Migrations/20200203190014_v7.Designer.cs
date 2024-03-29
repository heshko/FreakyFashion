﻿// <auto-generated />
using System;
using FreakyFashion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreakyFashion.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200203190014_v7")]
    partial class v7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FreakyFashion.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Material: 98% bomull, 2% elastan",
                            Name = "Chinos",
                            Price = 200f,
                            Type = "trouther",
                            image = "https://img01.ztat.net/article/PS/72/2E/01/AQ/11/PS722E01A-Q11@10.jpg?imwidth=300"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Material: Material: 100% polyester",
                            Name = "TRAIN LOGO PANT",
                            Price = 699f,
                            Type = "trouther",
                            image = "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Material: Best Byxor",
                            Name = "HYBRID PANT",
                            Price = 300f,
                            Type = "trouther",
                            image = "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Material: 90% polyester, 10% elastan",
                            Name = "FLEX WOVEN",
                            Price = 200f,
                            Type = "trouther",
                            image = "https://api.houdinisportswear.com/_images/9a5a6d71-5f4e-4eb2-84ff-87ea785e3c09/MsJoPants_P_BaremarkGreen_S.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Material: 79% bomull, 21% polyester",
                            Name = "TAPE PANTS",
                            Price = 700f,
                            Type = "trouther",
                            image = "https://www.verywellfit.com/thmb/11wnypV38gPbWQYjKqkhmdGc1LY=/640x640/smart/filters:no_upscale()/IntentJogger30-5a68b0b243a103001afe7475.jpeg"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Material: 100% bomull",
                            Name = "Tygbyxor",
                            Price = 400f,
                            Type = "trouther",
                            image = "https://revolutionrace.imgix.net/6119-large_default/twisted-outdoor-jeans-mens-anthracite.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Material: 84% polyester, 15% viskos, 1% elastan",
                            Name = "Tygbyxor",
                            Price = 200f,
                            Type = "trouther",
                            image = "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oqd1pzehuh6pqdsjtoy4/sportswear-tech-fleece-trousers-vWH3lg.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Material: 97% bomull, 3% elastanr",
                            Name = "Tygbyxor",
                            Price = 200f,
                            Type = "trouther",
                            image = "https://imgcdn.carhartt.com/is/image/Carhartt/B324ARG?$400L2$"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Material: 100% bomull",
                            Name = "Piké",
                            Price = 700f,
                            Type = "shirts",
                            image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560808195-fila-1560808184.jpg"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Material: 100% bomull",
                            Name = "FLORAL PANEL - Piké",
                            Price = 100f,
                            Type = "shirts",
                            image = "https://cdni.llbean.net/is/image/wim/224547_36814_41?hei=1095&wid=950&resMode=sharp2&defaultImage=llbstage/A0211793_2"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Material: 100% bomull",
                            Name = "CHECK - Piké",
                            Price = 190f,
                            Type = "shirts",
                            image = "https://www.all4o.com/image/cache/data/brand/TrueStory/TRUE-STORY-Elite-orienteering-shirt-Men-Deep-BLUE-800x800.jpg"
                        },
                        new
                        {
                            Id = 12,
                            Description = "Material: 60% bomull, 40% polyester",
                            Name = "Sweatshirt",
                            Price = 200f,
                            Type = "shirts",
                            image = "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Champion-Boys-Logo-Dip-Dyed-Sunny-Yellow-T-Shirt--_308437.jpg"
                        },
                        new
                        {
                            Id = 13,
                            Description = "Material: 100% bomull",
                            Name = "Piké",
                            Price = 400f,
                            Type = "shirts",
                            image = "https://images.www.fendi.com/images/h07/h2b/8971945836574/FS7255A5XSF0GME_01_medium"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Material: 100% bomull",
                            Name = "BASIC 2 PACK - Piké",
                            Price = 700f,
                            Type = "shirts",
                            image = "https://prochoice.org/wp-content/uploads/t-shirt_transparent-234x300.png"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Material: 100% bomull",
                            Name = "GEO ALL - Piké",
                            Price = 200f,
                            Type = "shirts",
                            image = "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1558112729-frame-chloe-king-1558112717.jpg"
                        },
                        new
                        {
                            Id = 16,
                            Description = "MATERIAL & SKÖTSEL",
                            Name = "CAMBRIDGE - Piké",
                            Price = 300f,
                            Type = "shirts",
                            image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSpHudtzLUfAXABtMXmcO0Kyvuru1fOfa25N8ZgjGgzSC29CdaN"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Material: 100% viskos",
                            Name = "TAMAYO DRESS",
                            Price = 900f,
                            Type = "dress",
                            image = "https://cdn.shopify.com/s/files/1/2714/9310/products/Unique_Vintage_1950s_Black_Embroidered_Red_Rose_Baltimore_Swing_Dress_1024x1024.jpg?v=1571711475"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Material: 100% viskos",
                            Name = "MNIA DRESS",
                            Price = 200f,
                            Type = "dress",
                            image = "https://photo.venus.com/im/18062700.jpg?preset=product"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Material: 100% viskos",
                            Name = "GILLEA - Skjortklänning",
                            Price = 1200f,
                            Type = "dress",
                            image = "https://is4.revolveassets.com/images/p4/n/c/AXIS-WD409_V1.jpg"
                        },
                        new
                        {
                            Id = 20,
                            Description = "Material: 100% polyester",
                            Name = "VALENTINA DRESS - Skjortklänning",
                            Price = 400f,
                            Type = "dress",
                            image = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width="
                        },
                        new
                        {
                            Id = 21,
                            Description = "Material: 100% polyester",
                            Name = "AMARIS LONG KIMONO",
                            Price = 400f,
                            Type = "dress",
                            image = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width="
                        },
                        new
                        {
                            Id = 22,
                            Description = "Material: 100% polyester",
                            Name = "CETO DRAWSTRING",
                            Price = 400f,
                            Type = "dress",
                            image = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width="
                        },
                        new
                        {
                            Id = 23,
                            Description = "Material: 100% viskos",
                            Name = "NINGBOX - Skjortklänning",
                            Price = 400f,
                            Type = "dress",
                            image = "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width="
                        },
                        new
                        {
                            Id = 24,
                            Description = "Material: 100% viskos",
                            Name = "PCNICOLETTA DRESS - Skjortklänning",
                            Price = 400f,
                            Type = "dress",
                            image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSJcssYg9A7u-6EBTode1IUBygxPnO1gk6GvyzzsT7ze3mBS2U-"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
