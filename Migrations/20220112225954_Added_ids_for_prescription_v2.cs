using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyStorage.Migrations
{
    public partial class Added_ids_for_prescription_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Prescription_ClientID",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_DoctorID",
                table: "Prescription");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_ClientID",
                table: "Prescription",
                column: "ClientID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_DoctorID",
                table: "Prescription",
                column: "DoctorID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Prescription_ClientID",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_DoctorID",
                table: "Prescription");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_ClientID",
                table: "Prescription",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_DoctorID",
                table: "Prescription",
                column: "DoctorID");
        }
    }
}
