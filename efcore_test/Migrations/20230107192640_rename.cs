using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcoretest.Migrations
{
    /// <inheritdoc />
    public partial class rename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_books",
                table: "tb_books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "tb_books",
                newName: "Bks");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "TB_Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bks",
                table: "Bks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_Person",
                table: "TB_Person",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_Person",
                table: "TB_Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bks",
                table: "Bks");

            migrationBuilder.RenameTable(
                name: "TB_Person",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "Bks",
                newName: "tb_books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_books",
                table: "tb_books",
                column: "Id");
        }
    }
}
