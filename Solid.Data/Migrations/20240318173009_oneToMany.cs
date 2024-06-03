using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Solid.Data.Migrations
{
    public partial class oneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BiuldingList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberStreet = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BiuldingList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TenantList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BiuldingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TenantList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TenantList_BiuldingList_BiuldingId",
                        column: x => x.BiuldingId,
                        principalTable: "BiuldingList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    TenantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentList", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentList_TenantList_TenantId",
                        column: x => x.TenantId,
                        principalTable: "TenantList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentList_TenantId",
                table: "PaymentList",
                column: "TenantId");

            migrationBuilder.CreateIndex(
                name: "IX_TenantList_BiuldingId",
                table: "TenantList",
                column: "BiuldingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentList");

            migrationBuilder.DropTable(
                name: "TenantList");

            migrationBuilder.DropTable(
                name: "BiuldingList");
        }
    }
}
