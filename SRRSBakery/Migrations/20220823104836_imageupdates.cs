using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRRSBakery.Migrations
{
    public partial class imageupdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ImageExtras_ItemId",
                table: "ImageExtras");

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 1,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AB.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AD_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 2,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-B_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-D_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 3,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-B_1.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-D_1.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 4,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-B_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-D_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 5,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AB.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-choco-vanilla-cake-2-cake893chva-C_1.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 6,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-mango-cake0020frui-B_2.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-mango-cake0020frui-E.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 7,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AB.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AD.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 8,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-B_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-F_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 9,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-B_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-D_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 10,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-B_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-C_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 11,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-C_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-D_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 12,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-B_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-D_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 13,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-B.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-C.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 14,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-B_1.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-C_1.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 15,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-B_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-C_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 16,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-C_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-D_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 17,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AB.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AD.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 18,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 19,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 20,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 21,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 22,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg?tr=w-400,h-400,q-100", "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg?tr=w-400,h-400,q-100" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 69,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AA.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 70,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 71,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-A_1.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 72,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 73,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-choco-vanilla-cake-2-cake893chva-A_1.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 74,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-mango-cake0020frui-A_2.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 75,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AA.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 76,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 77,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 78,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 79,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 80,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 81,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-A.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 82,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-A_1.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 83,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 84,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 85,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AA.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 86,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 87,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 88,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 89,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 90,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg?tr=w-400,h-400,q-100");

            migrationBuilder.CreateIndex(
                name: "IX_ImageExtras_ItemId",
                table: "ImageExtras",
                column: "ItemId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ImageExtras_ItemId",
                table: "ImageExtras");

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 1,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AB.jpg", "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AD_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 2,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-B_0.jpg", "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-D_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 3,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-B_1.jpg", "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-D_1.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 4,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-B_0.jpg", "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-D_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 5,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AB.jpg", "https://media.bakingo.com/sq-choco-vanilla-cake-2-cake893chva-C_1.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 6,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-mango-cake0020frui-B_2.jpg", "https://media.bakingo.com/sq-mango-cake0020frui-E.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 7,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AB.jpg", "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AD.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 8,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-B_0.jpg", "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-F_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 9,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-B_0.jpg", "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-D_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 10,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-B_0.jpg", "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-C_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 11,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-C_0.jpg", "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-D_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 12,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-B_0.jpg", "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-D_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 13,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-B.jpg", "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-C.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 14,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-B_1.jpg", "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-C_1.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 15,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-B_0.jpg", "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-C_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 16,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-C_0.jpg", "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-D_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 17,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AB.jpg", "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AD.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 18,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg", "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 19,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg", "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 20,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg", "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 21,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg", "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg" });

            migrationBuilder.UpdateData(
                table: "ImageExtras",
                keyColumn: "ImageExtraId",
                keyValue: 22,
                columns: new[] { "ImageUrlSecondLarge", "ImageUrlThirdLarge" },
                values: new object[] { "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg", "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 69,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AA.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 70,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 71,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-A_1.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 72,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 73,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-choco-vanilla-cake-2-cake893chva-A_1.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 74,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-mango-cake0020frui-A_2.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 75,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AA.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 76,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 77,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 78,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 79,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 80,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 81,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-A.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 82,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-A_1.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 83,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 84,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 85,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AA.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 86,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 87,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 88,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 89,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 90,
                column: "ImageUrlLarge",
                value: "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg");

            migrationBuilder.CreateIndex(
                name: "IX_ImageExtras_ItemId",
                table: "ImageExtras",
                column: "ItemId");
        }
    }
}
