using Microsoft.EntityFrameworkCore.Migrations;

namespace FreakyFashion.Data.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Material: 98% bomull, 2% elastan", "Chinos", "https://images.hugoboss.com/is/image/boss/hbeu50332479_001_100" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: Material: 100% polyester", "TRAIN LOGO PANT", 699f, "https://img01.ztat.net/article/TH/32/2E/00/5Q/11/TH322E005-Q11@8.jpg?imwidth=762" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Material: Best Byxor", 300f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Material: 90% polyester, 10% elastan", "FLEX WOVEN", "https://api.houdinisportswear.com/_images/9a5a6d71-5f4e-4eb2-84ff-87ea785e3c09/MsJoPants_P_BaremarkGreen_S.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 79% bomull, 21% polyester", "TAPE PANTS", 700f, "https://www.verywellfit.com/thmb/11wnypV38gPbWQYjKqkhmdGc1LY=/640x640/smart/filters:no_upscale()/IntentJogger30-5a68b0b243a103001afe7475.jpeg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 100% bomull", "Tygbyxor", 400f, "https://revolutionrace.imgix.net/6119-large_default/twisted-outdoor-jeans-mens-anthracite.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Material: 84% polyester, 15% viskos, 1% elastan", "Tygbyxor", "https://c.static-nike.com/a/images/t_PDP_1280_v1/f_auto/oqd1pzehuh6pqdsjtoy4/sportswear-tech-fleece-trousers-vWH3lg.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Material: 97% bomull, 3% elastanr", "Tygbyxor", "https://imgcdn.carhartt.com/is/image/Carhartt/B324ARG?$400L2$" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 100% bomull", "Piké", 700f, "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1560808195-fila-1560808184.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 100% bomull", "FLORAL PANEL - Piké", 100f, "https://cdni.llbean.net/is/image/wim/224547_36814_41?hei=1095&wid=950&resMode=sharp2&defaultImage=llbstage/A0211793_2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 100% bomull", "CHECK - Piké", 190f, "https://www.all4o.com/image/cache/data/brand/TrueStory/TRUE-STORY-Elite-orienteering-shirt-Men-Deep-BLUE-800x800.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Material: 60% bomull, 40% polyester", "Sweatshirt", "https://scene7.zumiez.com/is/image/zumiez/pdp_hero/Champion-Boys-Logo-Dip-Dyed-Sunny-Yellow-T-Shirt--_308437.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 100% bomull", "Piké", 400f, "https://images.www.fendi.com/images/h07/h2b/8971945836574/FS7255A5XSF0GME_01_medium" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 100% bomull", "BASIC 2 PACK - Piké", 700f, "https://prochoice.org/wp-content/uploads/t-shirt_transparent-234x300.png" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Material: 100% bomull", "GEO ALL - Piké", "https://hips.hearstapps.com/vader-prod.s3.amazonaws.com/1558112729-frame-chloe-king-1558112717.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "MATERIAL & SKÖTSEL", "CAMBRIDGE - Piké", 300f, "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSpHudtzLUfAXABtMXmcO0Kyvuru1fOfa25N8ZgjGgzSC29CdaN" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Price", "image" },
                values: new object[] { "Material: 100% viskos", 900f, "https://cdn.shopify.com/s/files/1/2714/9310/products/Unique_Vintage_1950s_Black_Embroidered_Red_Rose_Baltimore_Swing_Dress_1024x1024.jpg?v=1571711475" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Material: 100% viskos", "MNIA DRESS", "https://photo.venus.com/im/18062700.jpg?preset=product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 100% viskos", "GILLEA - Skjortklänning", 1200f, "https://is4.revolveassets.com/images/p4/n/c/AXIS-WD409_V1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Material: 100% polyester", "VALENTINA DRESS - Skjortklänning", 400f, "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Type", "image" },
                values: new object[,]
                {
                    { 23, "Material: 100% viskos", "NINGBOX - Skjortklänning", 400f, "dress", "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=" },
                    { 22, "Material: 100% polyester", "CETO DRAWSTRING", 400f, "dress", "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=" },
                    { 24, "Material: 100% viskos", "PCNICOLETTA DRESS - Skjortklänning", 400f, "dress", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSJcssYg9A7u-6EBTode1IUBygxPnO1gk6GvyzzsT7ze3mBS2U-" },
                    { 21, "Material: 100% polyester", "AMARIS LONG KIMONO", 400f, "dress", "https://www.chichiclothing.com/media/catalog/product/c/h/charissa__74755_zoom.jpg?quality=80&bg-color=255,255,255&fit=bounds&height=&width=" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Best Byxor", "HYBRID PANT", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Byxor", "HYBRID PANT", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Price" },
                values: new object[] { "Best Byxor", 200f });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Best Byxor", "HYBRID PANT", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Byxor", "HYBRID PANT", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Byxor", "HYBRID PANT", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Best Byxor", "HYBRID PANT", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Best Byxor", "HYBRID PANT", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Blus", "Blus", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Blus", "Blus", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Blus", "Blus", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Best Blus", "Blus", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Blus", "Blus", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Blus", "Blus", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Best Blus", "Blus", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Blus", "Blus", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "Price", "image" },
                values: new object[] { "Best Blus", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Name", "image" },
                values: new object[] { "Best Blus", "TAMAYO DRESS", "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Blus", "TAMAYO DRESS", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Name", "Price", "image" },
                values: new object[] { "Best Blus", "TAMAYO DRESS", 200f, "https://tkdesign.se/575-home_default/nyhet-byxor-i-100-krinklad-bomull-inkommer-den-2510.jpg" });
        }
    }
}
