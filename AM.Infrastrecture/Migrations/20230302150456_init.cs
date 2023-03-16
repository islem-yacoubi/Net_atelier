using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastrecture.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights");

            migrationBuilder.DropTable(
                name: "FlightPassenger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "PassportNumber",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "EstimationDuration",
                table: "Flights");

            migrationBuilder.RenameTable(
                name: "Flights",
                newName: "MyFligt");

            migrationBuilder.RenameColumn(
                name: "planeType",
                table: "Planes",
                newName: "PlaneType");

            migrationBuilder.RenameColumn(
                name: "ManufactureDate",
                table: "Planes",
                newName: "ManualFactureDate");

            migrationBuilder.RenameColumn(
                name: "Departure",
                table: "MyFligt",
                newName: "ville de depart");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "MyFligt",
                newName: "PlaneFK");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_PlaneId",
                table: "MyFligt",
                newName: "IX_MyFligt_PlaneFK");

            migrationBuilder.AlterColumn<double>(
                name: "Capacity",
                table: "Planes",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PasseportNumber",
                table: "Passengers",
                type: "int",
                maxLength: 7,
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ville de depart",
                table: "MyFligt",
                type: "nchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "TOUNES",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "EstimatedDuration",
                table: "MyFligt",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "PasseportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyFligt",
                table: "MyFligt",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFligt_Planes_PlaneFK",
                table: "MyFligt",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFligt_Planes_PlaneFK",
                table: "MyFligt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyFligt",
                table: "MyFligt");

            migrationBuilder.DropColumn(
                name: "PasseportNumber",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "EstimatedDuration",
                table: "MyFligt");

            migrationBuilder.RenameTable(
                name: "MyFligt",
                newName: "Flights");

            migrationBuilder.RenameColumn(
                name: "PlaneType",
                table: "Planes",
                newName: "planeType");

            migrationBuilder.RenameColumn(
                name: "ManualFactureDate",
                table: "Planes",
                newName: "ManufactureDate");

            migrationBuilder.RenameColumn(
                name: "ville de depart",
                table: "Flights",
                newName: "Departure");

            migrationBuilder.RenameColumn(
                name: "PlaneFK",
                table: "Flights",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_MyFligt_PlaneFK",
                table: "Flights",
                newName: "IX_Flights_PlaneId");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Planes",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PassportNumber",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Departure",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(100)",
                oldMaxLength: 100,
                oldDefaultValue: "TOUNES");

            migrationBuilder.AddColumn<int>(
                name: "EstimationDuration",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passengers",
                table: "Passengers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "FlightId");

            migrationBuilder.CreateTable(
                name: "FlightPassenger",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    passengersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassenger", x => new { x.FlightsFlightId, x.passengersId });
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Flights_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassenger_Passengers_passengersId",
                        column: x => x.passengersId,
                        principalTable: "Passengers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassenger_passengersId",
                table: "FlightPassenger",
                column: "passengersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Planes_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
