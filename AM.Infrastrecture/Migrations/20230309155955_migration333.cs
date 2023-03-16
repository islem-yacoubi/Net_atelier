using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastrecture.Migrations
{
    /// <inheritdoc />
    public partial class migration333 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_MyFligt_FlightId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passengers_PassengerPasseportNumber",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_PassengerPasseportNumber",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "PassengerPasseportNumber",
                table: "Ticket");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightFk",
                table: "Ticket",
                column: "FlightFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_MyFligt_FlightFk",
                table: "Ticket",
                column: "FlightFk",
                principalTable: "MyFligt",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passengers_PassengerFk",
                table: "Ticket",
                column: "PassengerFk",
                principalTable: "Passengers",
                principalColumn: "PasseportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_MyFligt_FlightFk",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Passengers_PassengerFk",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_FlightFk",
                table: "Ticket");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassengerPasseportNumber",
                table: "Ticket",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_FlightId",
                table: "Ticket",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_PassengerPasseportNumber",
                table: "Ticket",
                column: "PassengerPasseportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_MyFligt_FlightId",
                table: "Ticket",
                column: "FlightId",
                principalTable: "MyFligt",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Passengers_PassengerPasseportNumber",
                table: "Ticket",
                column: "PassengerPasseportNumber",
                principalTable: "Passengers",
                principalColumn: "PasseportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
