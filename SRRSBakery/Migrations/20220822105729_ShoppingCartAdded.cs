using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SRRSBakery.Migrations
{
    public partial class ShoppingCartAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetails_Items_ItemId",
                table: "OrdersDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdersDetails_Orders_OrderId",
                table: "OrdersDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Shoppingitemcart_Items_ItemId",
                table: "Shoppingitemcart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shoppingitemcart",
                table: "Shoppingitemcart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdersDetails",
                table: "OrdersDetails");

            migrationBuilder.RenameTable(
                name: "Shoppingitemcart",
                newName: "ShoppingCartItems");

            migrationBuilder.RenameTable(
                name: "OrdersDetails",
                newName: "OrderDetails");

            migrationBuilder.RenameIndex(
                name: "IX_Shoppingitemcart_ItemId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersDetails_OrderId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdersDetails_ItemId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems",
                column: "ShoppingCartItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Items_ItemId",
                table: "OrderDetails",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Items_ItemId",
                table: "ShoppingCartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Items_ItemId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Orders_OrderId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Items_ItemId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCartItems",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "ShoppingCartItems",
                newName: "Shoppingitemcart");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrdersDetails");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_ItemId",
                table: "Shoppingitemcart",
                newName: "IX_Shoppingitemcart_ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrdersDetails",
                newName: "IX_OrdersDetails_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_ItemId",
                table: "OrdersDetails",
                newName: "IX_OrdersDetails_ItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shoppingitemcart",
                table: "Shoppingitemcart",
                column: "ShoppingCartItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdersDetails",
                table: "OrdersDetails",
                column: "OrderDetailsId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetails_Items_ItemId",
                table: "OrdersDetails",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdersDetails_Orders_OrderId",
                table: "OrdersDetails",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shoppingitemcart_Items_ItemId",
                table: "Shoppingitemcart",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
