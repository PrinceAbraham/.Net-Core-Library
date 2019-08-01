using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryData.Migrations
{
    public partial class ChangeidtoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetid",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryAssets_LibraryAssetid",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetid",
                table: "Holds");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "LibraryAssets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LibraryAssetid",
                table: "Holds",
                newName: "LibraryAssetId");

            migrationBuilder.RenameIndex(
                name: "IX_Holds_LibraryAssetid",
                table: "Holds",
                newName: "IX_Holds_LibraryAssetId");

            migrationBuilder.RenameColumn(
                name: "LibraryAssetid",
                table: "Checkouts",
                newName: "LibraryAssetId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Checkouts",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Checkouts_LibraryAssetid",
                table: "Checkouts",
                newName: "IX_Checkouts_LibraryAssetId");

            migrationBuilder.RenameColumn(
                name: "LibraryAssetid",
                table: "CheckoutHistories",
                newName: "LibraryAssetId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CheckoutHistories",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryAssetid",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryAssetId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "BranchHours",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistories",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryAssets_LibraryAssetId",
                table: "Checkouts",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds",
                column: "LibraryAssetId",
                principalTable: "LibraryAssets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetId",
                table: "CheckoutHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_LibraryAssets_LibraryAssetId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetId",
                table: "Holds");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LibraryAssets",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LibraryAssetId",
                table: "Holds",
                newName: "LibraryAssetid");

            migrationBuilder.RenameIndex(
                name: "IX_Holds_LibraryAssetId",
                table: "Holds",
                newName: "IX_Holds_LibraryAssetid");

            migrationBuilder.RenameColumn(
                name: "LibraryAssetId",
                table: "Checkouts",
                newName: "LibraryAssetid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Checkouts",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Checkouts_LibraryAssetId",
                table: "Checkouts",
                newName: "IX_Checkouts_LibraryAssetid");

            migrationBuilder.RenameColumn(
                name: "LibraryAssetId",
                table: "CheckoutHistories",
                newName: "LibraryAssetid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CheckoutHistories",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_CheckoutHistories_LibraryAssetId",
                table: "CheckoutHistories",
                newName: "IX_CheckoutHistories_LibraryAssetid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BranchHours",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CheckoutHistories_LibraryAssets_LibraryAssetid",
                table: "CheckoutHistories",
                column: "LibraryAssetid",
                principalTable: "LibraryAssets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_LibraryAssets_LibraryAssetid",
                table: "Checkouts",
                column: "LibraryAssetid",
                principalTable: "LibraryAssets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Holds_LibraryAssets_LibraryAssetid",
                table: "Holds",
                column: "LibraryAssetid",
                principalTable: "LibraryAssets",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
