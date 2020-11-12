using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroCreator.Data.Migrations
{
    public partial class modifiedprimarykey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Superheroes",
                table: "Superheroes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Superheroes",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Superheroes",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Superheroes",
                table: "Superheroes",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Superheroes",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Superheroes");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Superheroes",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Superheroes",
                table: "Superheroes",
                column: "Name");
        }
    }
}
