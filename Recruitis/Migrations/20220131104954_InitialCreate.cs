using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recruitis.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Risk",
                columns: table => new
                {
                    RiskID = table.Column<int>(type: "int", nullable: false),
                    RiskLabel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risk", x => x.RiskID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false),
                    RiskLabel = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    CompanysCompanyID = table.Column<int>(type: "int", nullable: false),
                    RisksRiskID = table.Column<int>(type: "int", nullable: true),
                    StatussStatusID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Client_Company_CompanysCompanyID",
                        column: x => x.CompanysCompanyID,
                        principalTable: "Company",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Client_Risk_RisksRiskID",
                        column: x => x.RisksRiskID,
                        principalTable: "Risk",
                        principalColumn: "RiskID");
                    table.ForeignKey(
                        name: "FK_Client_Status_StatussStatusID",
                        column: x => x.StatussStatusID,
                        principalTable: "Status",
                        principalColumn: "StatusID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_CompanysCompanyID",
                table: "Client",
                column: "CompanysCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_RisksRiskID",
                table: "Client",
                column: "RisksRiskID");

            migrationBuilder.CreateIndex(
                name: "IX_Client_StatussStatusID",
                table: "Client",
                column: "StatussStatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Risk");

            migrationBuilder.DropTable(
                name: "Status");
        }
    }
}
