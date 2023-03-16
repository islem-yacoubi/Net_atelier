using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastrecture.Migrations
{
    /// <inheritdoc />
    public partial class migration33 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "My Reservation");

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    FlightFk = table.Column<int>(type: "int", nullable: false),
                    PassengerFk = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Prix = table.Column<double>(type: "float(2)", precision: 2, scale: 3, nullable: false),
                    Siege = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    PassengerPasseportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => new { x.PassengerFk, x.FlightFk });
                    table.ForeignKey(
                        name: "FK_Ticket_MyFligt_FlightId",
                        column: x => x.FlightId,
                        principalTable: "MyFligt",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ticket_Passengers_PassengerPasseportNumber",
                        column: x => x.PassengerPasseportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PasseportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerPasseportNumber",
                table: "Ticket",
                column: "PassengerPasseportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

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
                name: "IX_My Reservation_PassesPasseportNumber",
                table: "My Reservation",
                column: "PassesPasseportNumber");
        }
    }
}
