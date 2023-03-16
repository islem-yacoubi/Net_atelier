using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastrecture.Migrations
{
    /// <inheritdoc />
    public partial class migration17 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName_LastName",
                table: "Passengers",
                newName: "lastname");

            migrationBuilder.AlterColumn<string>(
                name: "FullName_FirstName",
                table: "Passengers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);

            migrationBuilder.AlterColumn<string>(
                name: "lastname",
                table: "Passengers",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "Passengers",
                newName: "FullName_LastName");

            migrationBuilder.AlterColumn<string>(
                name: "FullName_FirstName",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FullName_LastName",
                table: "Passengers",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
