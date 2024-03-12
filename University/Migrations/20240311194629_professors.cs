using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace University.Migrations
{
    /// <inheritdoc />
    public partial class professors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Professors",
                columns: new[] { "Id", "DepartmentID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "momen" },
                    { 2, 1, "mina" },
                    { 3, 2, "amira" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Professors_DepartmentID",
                table: "Professors",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Professors_Departments_DepartmentID",
                table: "Professors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professors_Departments_DepartmentID",
                table: "Professors");

            migrationBuilder.DropIndex(
                name: "IX_Professors_DepartmentID",
                table: "Professors");

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Professors",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
