using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library_DEPI.Migrations
{
    /// <inheritdoc />
    public partial class initialdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_CheckoutViewModel_CheckoutViewModelId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_CheckoutViewModel_CheckoutViewModelId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "CheckoutViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Books_CheckoutViewModelId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CheckoutViewModelId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "330b5270-907a-4e05-8c64-29e5220e1584");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3da1b61f-b0cf-4452-8ac4-0028d1a30bd3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f24bbec1-ad0f-4de1-beba-d5e229508fab");

            migrationBuilder.DropColumn(
                name: "CheckoutViewModelId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CheckoutViewModelId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a99c618-e0cf-452e-b147-0bf3e222dac0", "1dc3fc47-c94b-40bd-be4a-d57c0cfd8e75", "Admin", "admin" },
                    { "2916d611-a0ca-43bb-9827-383fcb09f7e2", "7305bbfc-ae6b-4c07-b131-c51c91935b27", "Super Admin", "super admin" },
                    { "a04bcd47-5521-49ab-b278-e5ccc6c74c97", "1fb58cad-60af-4ea3-b8dc-4bbfd2a05cad", "User", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a99c618-e0cf-452e-b147-0bf3e222dac0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2916d611-a0ca-43bb-9827-383fcb09f7e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a04bcd47-5521-49ab-b278-e5ccc6c74c97");

            migrationBuilder.AddColumn<int>(
                name: "CheckoutViewModelId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CheckoutViewModelId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CheckoutViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CheckoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SelectedBookId = table.Column<int>(type: "int", nullable: false),
                    SelectedUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CheckoutViewModel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "330b5270-907a-4e05-8c64-29e5220e1584", "66fa2765-94f9-478f-a153-b6f58367cbea", "User", "user" },
                    { "3da1b61f-b0cf-4452-8ac4-0028d1a30bd3", "5071510c-04f1-4e11-b0c8-46934b95273d", "Admin", "admin" },
                    { "f24bbec1-ad0f-4de1-beba-d5e229508fab", "e22f41db-52fb-4dcc-956f-2de18dbab759", "Super Admin", "super admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CheckoutViewModelId",
                table: "Books",
                column: "CheckoutViewModelId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CheckoutViewModelId",
                table: "AspNetUsers",
                column: "CheckoutViewModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_CheckoutViewModel_CheckoutViewModelId",
                table: "AspNetUsers",
                column: "CheckoutViewModelId",
                principalTable: "CheckoutViewModel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_CheckoutViewModel_CheckoutViewModelId",
                table: "Books",
                column: "CheckoutViewModelId",
                principalTable: "CheckoutViewModel",
                principalColumn: "Id");
        }
    }
}
