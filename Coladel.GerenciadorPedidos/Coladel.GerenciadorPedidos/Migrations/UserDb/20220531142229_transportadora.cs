using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coladel.GerenciadorPedidos.Migrations.UserDb
{
    public partial class transportadora : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contatos",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(type: "varchar(126)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    telefone = table.Column<string>(type: "varchar(12)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    celular = table.Column<string>(type: "varchar(14)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contatos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "enderecos",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cep = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    logradouro = table.Column<string>(type: "varchar(126)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    numero = table.Column<string>(type: "varchar(5)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    complemento = table.Column<string>(type: "varchar(126)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bairro = table.Column<string>(type: "varchar(26)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cidade = table.Column<string>(type: "varchar(26)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    estado = table.Column<string>(type: "varchar(2)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "transportadoras",
                columns: table => new
                {
                    id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id_contato = table.Column<short>(type: "smallint", nullable: true),
                    id_endereco = table.Column<short>(type: "smallint", nullable: true),
                    cod_transportadora = table.Column<string>(type: "varchar(10)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome = table.Column<string>(type: "varchar(126)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    nome_fantasia = table.Column<string>(type: "varchar(126)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    observacao = table.Column<string>(type: "varchar(256)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    website = table.Column<string>(type: "varchar(100)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    guid = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    data_cadastro = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transportadoras", x => x.id);
                    table.ForeignKey(
                        name: "FK_transportadoras_contatos_id_contato",
                        column: x => x.id_contato,
                        principalTable: "contatos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_transportadoras_enderecos_id_endereco",
                        column: x => x.id_endereco,
                        principalTable: "enderecos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_transportadoras_id_contato",
                table: "transportadoras",
                column: "id_contato",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_transportadoras_id_endereco",
                table: "transportadoras",
                column: "id_endereco",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transportadoras");

            migrationBuilder.DropTable(
                name: "contatos");

            migrationBuilder.DropTable(
                name: "enderecos");
        }
    }
}
