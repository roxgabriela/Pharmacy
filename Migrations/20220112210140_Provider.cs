using Microsoft.EntityFrameworkCore.Migrations;

namespace PharmacyStorage.Migrations
{
    public partial class Provider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProviderID",
                table: "Medicine",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Provider",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactoryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provider", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Medicine_ProviderID",
                table: "Medicine",
                column: "ProviderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicine_Provider_ProviderID",
                table: "Medicine",
                column: "ProviderID",
                principalTable: "Provider",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicine_Provider_ProviderID",
                table: "Medicine");

            migrationBuilder.DropTable(
                name: "Provider");

            migrationBuilder.DropIndex(
                name: "IX_Medicine_ProviderID",
                table: "Medicine");

            migrationBuilder.DropColumn(
                name: "ProviderID",
                table: "Medicine");
        }
    }
}
