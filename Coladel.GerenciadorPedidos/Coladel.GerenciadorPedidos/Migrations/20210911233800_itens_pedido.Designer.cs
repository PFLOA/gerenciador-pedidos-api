﻿// <auto-generated />
using System;
using Coladel.GerenciadorPedidos.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Coladel.GerenciadorPedidos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210911233800_itens_pedido")]
    partial class itens_pedido
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.Cliente", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_cadastro");

                    b.Property<Guid>("Guid")
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<string>("NomeCliente")
                        .HasColumnType("varchar(256)")
                        .HasColumnName("nome_cliente");

                    b.HasKey("Id");

                    b.ToTable("cliente");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.ItensPedido", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_cadastro");

                    b.Property<Guid>("Guid")
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<short>("IdPedido")
                        .HasColumnType("smallint")
                        .HasColumnName("id_pedido");

                    b.Property<short>("IdProduto")
                        .HasColumnType("smallint")
                        .HasColumnName("id_produto");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int")
                        .HasColumnName("quantidade");

                    b.HasKey("Id");

                    b.HasIndex("IdPedido");

                    b.HasIndex("IdProduto");

                    b.ToTable("itens_pedido");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.Pedido", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_cadastro");

                    b.Property<Guid>("Guid")
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<short>("IdCliente")
                        .HasColumnType("smallint")
                        .HasColumnName("id_cliente");

                    b.Property<string>("NF")
                        .HasColumnType("longtext")
                        .HasColumnName("nf");

                    b.Property<string>("Observacoes")
                        .HasColumnType("longtext")
                        .HasColumnName("observacoes");

                    b.Property<int>("StatusPedido")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("total");

                    b.HasKey("Id");

                    b.HasIndex("IdCliente");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.Produto", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_cadastro");

                    b.Property<Guid>("Guid")
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<string>("NomeProduto")
                        .HasColumnType("longtext")
                        .HasColumnName("nome_produto");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("preco");

                    b.HasKey("Id");

                    b.ToTable("produtos");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.Usuario", b =>
                {
                    b.Property<short>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasColumnName("id");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("data_cadastro");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<Guid>("Guid")
                        .HasColumnType("char(36)")
                        .HasColumnName("guid");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("nome");

                    b.Property<string>("Senha")
                        .HasColumnType("longtext")
                        .HasColumnName("senha");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext")
                        .HasColumnName("user_name");

                    b.HasKey("Id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.ItensPedido", b =>
                {
                    b.HasOne("Coladel.GerenciadorPedidos.Domain.Entidades.Pedido", "Pedido")
                        .WithMany("ItensPedido")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Coladel.GerenciadorPedidos.Domain.Entidades.Produto", "Produto")
                        .WithMany("ItensPedido")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.Pedido", b =>
                {
                    b.HasOne("Coladel.GerenciadorPedidos.Domain.Entidades.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.Pedido", b =>
                {
                    b.Navigation("ItensPedido");
                });

            modelBuilder.Entity("Coladel.GerenciadorPedidos.Domain.Entidades.Produto", b =>
                {
                    b.Navigation("ItensPedido");
                });
#pragma warning restore 612, 618
        }
    }
}
