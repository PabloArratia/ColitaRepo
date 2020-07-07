using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ColitaWeb.Migrations
{
    public partial class CreateInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColitasEF",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ColitaName = table.Column<string>(nullable: true),
                    ColitaDescription = table.Column<string>(nullable: true),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    EstadoDeColita = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColitasEF", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColitasEF");
        }
    }
}
