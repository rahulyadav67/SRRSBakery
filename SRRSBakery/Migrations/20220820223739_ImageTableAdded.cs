using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRRSBakery.Migrations
{
    public partial class ImageTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageExtras",
                columns: table => new
                {
                    ImageExtraId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrlSecondLarge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrlThirdLarge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageExtras", x => x.ImageExtraId);
                    table.ForeignKey(
                        name: "FK_ImageExtras_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ImageExtras",
                columns: new[] { "ImageExtraId", "ImageUrlSecondLarge", "ImageUrlThirdLarge", "ItemId" },
                values: new object[,]
                {
                    { 1, "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AB.jpg", "https://media.bakingo.com/sq-choco-truffle-cake0005choc-AD_0.jpg", 69 },
                    { 2, "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-B_0.jpg", "https://media.bakingo.com/sq-red-velvet-chocolate-cake-cake1637redv-D_0.jpg", 70 },
                    { 3, "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-B_1.jpg", "https://media.bakingo.com/sq-round-buttery-delight-butterscotch-cake-cake2281butt-D_1.jpg", 71 },
                    { 4, "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-B_0.jpg", "https://media.bakingo.com/sq-round-pink-roses-vanilla-cake-rosecake2561vani-D_0.jpg", 72 },
                    { 5, "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AB.jpg", "https://media.bakingo.com/sq-choco-vanilla-cake-2-cake893chva-C_1.jpg", 73 },
                    { 6, "https://media.bakingo.com/sq-mango-cake0020frui-B_2.jpg", "https://media.bakingo.com/sq-mango-cake0020frui-E.jpg", 74 },
                    { 7, "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AB.jpg", "https://media.bakingo.com/sq-fresh-fruit-cake0014frui-AD.jpg", 75 },
                    { 8, "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-B_0.jpg", "https://media.bakingo.com/sq-dripping-with-deliciousness-red-velvet-cake-cake2297redv-F_0.jpg", 76 },
                    { 9, "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-B_0.jpg", "https://media.bakingo.com/sq-birthday-chocolate-overload-pinata-cake-750gm-pina2163choc-D_0.jpg", 77 },
                    { 10, "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-B_0.jpg", "https://media.bakingo.com/sq-round-snowman-happy-birthday-vanilla-cake-cake2407vani-C_0.jpg", 78 },
                    { 11, "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-C_0.jpg", "https://media.bakingo.com/sq-birthday-black-forest-pinata-cake-800gm-pina2042blac-D_0.jpg", 79 },
                    { 12, "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-B_0.jpg", "https://media.bakingo.com/sq-pineapple-gems-pinata-cake-pina2149pine-D_0.jpg", 80 },
                    { 13, "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-B.jpg", "https://media.bakingo.com/squ-heart-shaped-black-forest-vanilla-cake0039hbfv-C.jpg", 81 },
                    { 14, "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-B_1.jpg", "https://media.bakingo.com/sq-pink-hearty-rose-strawberry-cake-cake2536stra-C_1.jpg", 82 },
                    { 15, "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-B_0.jpg", "https://media.bakingo.com/sq-vanilla-heart-cake-cake1708vani-C_0.jpg", 83 },
                    { 16, "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-C_0.jpg", "https://media.bakingo.com/sq-pineapple-pinata-cake-450gm-pina2265pine-D_0.jpg", 84 },
                    { 17, "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AB.jpg", "https://media.bakingo.com/sq-snicker-chocolate-cake0028choc-AD.jpg", 85 },
                    { 18, "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg", "https://media.bakingo.com/sq-fondant-two-tier-cake-them1395flav-A_0.jpg", 86 },
                    { 19, "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg", "https://media.bakingo.com/sq-round-golden-jubilee-anniversary-cake-them1386flav-A_0.jpg", 87 },
                    { 20, "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg", "https://media.bakingo.com/sq3-tier-party-cake-for-any-celebration-A_0.jpg", 88 },
                    { 21, "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg", "https://media.bakingo.com/sq-4-tier-anniversary-party-cake-part1802flav_0.jpg", 89 },
                    { 22, "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg", "https://media.bakingo.com/sq-3-tier-royal-party-cake-part1796flav_0.jpg", 90 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImageExtras_ItemId",
                table: "ImageExtras",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageExtras");
        }
    }
}
