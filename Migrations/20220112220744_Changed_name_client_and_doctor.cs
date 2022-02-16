using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyStorage.Migrations
{
    public partial class Changed_name_client_and_doctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Doctor",
                newName: "DoctorName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Client",
                newName: "ClientName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DoctorName",
                table: "Doctor",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ClientName",
                table: "Client",
                newName: "Name");
        }
    }
}
