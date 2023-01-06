using Microsoft.EntityFrameworkCore.Migrations;

namespace Coladel.GerenciadorPedidos.Migrations.UserDb
{
    public partial class isorigem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_origem",
                table: "envio_emails",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_origem",
                table: "envio_emails");
        }
    }
}
