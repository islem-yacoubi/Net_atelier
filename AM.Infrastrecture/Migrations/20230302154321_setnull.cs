using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastrecture.Migrations
{
    /// <inheritdoc />
    public partial class setnull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFligt_Planes_PlaneFK",
                table: "MyFligt");

            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "Passengers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "MyFligt",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "My Reservation",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    PassesPasseportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_My Reservation", x => new { x.FlightsFlightId, x.PassesPasseportNumber });
                    table.ForeignKey(
                        name: "FK_My Reservation_MyFligt_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "MyFligt",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_My Reservation_Passengers_PassesPasseportNumber",
                        column: x => x.PassesPasseportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PasseportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_PlaneId",
                table: "Passengers",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_My Reservation_PassesPasseportNumber",
                table: "My Reservation",
                column: "PassesPasseportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_MyFligt_Planes_PlaneFK",
                table: "MyFligt",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Passengers_Planes_PlaneId",
                table: "Passengers",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "PlaneId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyFligt_Planes_PlaneFK",
                table: "MyFligt");

            migrationBuilder.DropForeignKey(
                name: "FK_Passengers_Planes_PlaneId",
                table: "Passengers");

            migrationBuilder.DropTable(
                name: "My Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Passengers_PlaneId",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "Passengers");

            migrationBuilder.AlterColumn<int>(
                name: "PlaneFK",
                table: "MyFligt",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFligt_Planes_PlaneFK",
                table: "MyFligt",
                column: "PlaneFK",
                principalTable: "Planes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
