using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Coladel.GerenciadorPedidos.Migrations
{
    public partial class itens_pedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedido_pedidos_PedidoId",
                table: "ItensPedido");

            migrationBuilder.DropForeignKey(
                name: "FK_ItensPedido_produtos_ProdutoId",
                table: "ItensPedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItensPedido",
                table: "ItensPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItensPedido_PedidoId",
                table: "ItensPedido");

            migrationBuilder.DropIndex(
                name: "IX_ItensPedido_ProdutoId",
                table: "ItensPedido");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "ItensPedido");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "ItensPedido");

            migrationBuilder.RenameTable(
                name: "ItensPedido",
                newName: "itens_pedido");

            migrationBuilder.RenameColumn(
                name: "Quantidade",
                table: "itens_pedido",
                newName: "quantidade");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "itens_pedido",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdProduto",
                table: "itens_pedido",
                newName: "id_produto");

            migrationBuilder.RenameColumn(
                name: "IdPedido",
                table: "itens_pedido",
                newName: "id_pedido");

            migrationBuilder.AddColumn<DateTime>(
                name: "data_cadastro",
                table: "itens_pedido",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "guid",
                table: "itens_pedido",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_itens_pedido",
                table: "itens_pedido",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_itens_pedido_id_pedido",
                table: "itens_pedido",
                column: "id_pedido");

            migrationBuilder.CreateIndex(
                name: "IX_itens_pedido_id_produto",
                table: "itens_pedido",
                column: "id_produto");

            migrationBuilder.AddForeignKey(
                name: "FK_itens_pedido_pedidos_id_pedido",
                table: "itens_pedido",
                column: "id_pedido",
                principalTable: "pedidos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_itens_pedido_produtos_id_produto",
                table: "itens_pedido",
                column: "id_produto",
                principalTable: "produtos",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_itens_pedido_pedidos_id_pedido",
                table: "itens_pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_itens_pedido_produtos_id_produto",
                table: "itens_pedido");

            migrationBuilder.DropPrimaryKey(
                name: "PK_itens_pedido",
                table: "itens_pedido");

            migrationBuilder.DropIndex(
                name: "IX_itens_pedido_id_pedido",
                table: "itens_pedido");

            migrationBuilder.DropIndex(
                name: "IX_itens_pedido_id_produto",
                table: "itens_pedido");

            migrationBuilder.DropColumn(
                name: "data_cadastro",
                table: "itens_pedido");

            migrationBuilder.DropColumn(
                name: "guid",
                table: "itens_pedido");

            migrationBuilder.RenameTable(
                name: "itens_pedido",
                newName: "ItensPedido");

            migrationBuilder.RenameColumn(
                name: "quantidade",
                table: "ItensPedido",
                newName: "Quantidade");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ItensPedido",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_produto",
                table: "ItensPedido",
                newName: "IdProduto");

            migrationBuilder.RenameColumn(
                name: "id_pedido",
                table: "ItensPedido",
                newName: "IdPedido");

            migrationBuilder.AddColumn<short>(
                name: "PedidoId",
                table: "ItensPedido",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "ProdutoId",
                table: "ItensPedido",
                type: "smallint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItensPedido",
                table: "ItensPedido",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ItensPedido_PedidoId",
                table: "ItensPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensPedido_ProdutoId",
                table: "ItensPedido",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedido_pedidos_PedidoId",
                table: "ItensPedido",
                column: "PedidoId",
                principalTable: "pedidos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItensPedido_produtos_ProdutoId",
                table: "ItensPedido",
                column: "ProdutoId",
                principalTable: "produtos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
