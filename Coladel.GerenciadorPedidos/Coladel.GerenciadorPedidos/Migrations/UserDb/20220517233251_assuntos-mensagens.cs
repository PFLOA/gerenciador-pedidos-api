using Microsoft.EntityFrameworkCore.Migrations;

namespace Coladel.GerenciadorPedidos.Migrations.UserDb
{
    public partial class assuntosmensagens : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "assunto",
                table: "envio_emails",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "mensagem",
                table: "envio_emails",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "assunto",
                table: "envio_emails");

            migrationBuilder.DropColumn(
                name: "mensagem",
                table: "envio_emails");
        }
    }
}
