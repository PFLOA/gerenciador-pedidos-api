using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coladel.GerenciadorPedidos.Migrations.UserDb
{
    public partial class configuracoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "configuracoes",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    mostrar_comissao = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    enviar_logistica = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    enviar_transportadora = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_configuracoes", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_configuracao = table.Column<short>(type: "smallint", nullable: false),
                    nome = table.Column<string>(type: "varchar(256)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.id);
                    table.ForeignKey(
                        name: "FK_empresa_configuracoes_id_configuracao",
                        column: x => x.id_configuracao,
                        principalTable: "configuracoes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "envio_emails",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_empresa = table.Column<short>(type: "smallint", nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    senha = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    port = table.Column<int>(type: "int", nullable: false),
                    smtp_cliente = table.Column<string>(type: "varchar(50)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tipo_email = table.Column<int>(type: "int", nullable: false),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_envio_emails", x => x.id);
                    table.ForeignKey(
                        name: "FK_envio_emails_empresa_id_empresa",
                        column: x => x.id_empresa,
                        principalTable: "empresa",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_id_configuracao",
                table: "empresa",
                column: "id_configuracao",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_envio_emails_id_empresa",
                table: "envio_emails",
                column: "id_empresa");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropTable(
                name: "envio_emails");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "configuracoes");
        }
    }
}
