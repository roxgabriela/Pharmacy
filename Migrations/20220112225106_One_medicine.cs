using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyStorage.Migrations
{
    public partial class One_medicine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_Prescription_PrescriptionID",
                table: "Medicine");

            migrationBuilder.DropIndex(
                name: "IX_Medicine_PrescriptionID",
                table: "Medicine");

            migrationBuilder.DropColumn(
                name: "PrescriptionID",
                table: "Medicine");

            migrationBuilder.AddColumn<int>(
                name: "MedicineID",
                table: "Prescription",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Prescription_MedicineID",
                table: "Prescription",
                column: "MedicineID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicine_MedicineID",
                table: "Prescription",
                column: "MedicineID",
                principalTable: "Medicine",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicine_MedicineID",
                table: "Prescription");

            migrationBuilder.DropIndex(
                name: "IX_Prescription_MedicineID",
                table: "Prescription");

            migrationBuilder.DropColumn(
                name: "MedicineID",
                table: "Prescription");

            migrationBuilder.AddColumn<int>(
                name: "PrescriptionID",
                table: "Medicine",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_PrescriptionID",
                table: "Medicine",
                column: "PrescriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_Prescription_PrescriptionID",
                table: "Medicine",
                column: "PrescriptionID",
                principalTable: "Prescription",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
