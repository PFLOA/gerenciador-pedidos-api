<<<<<<< HEAD
﻿using A4S.ERP.Domain.Entidades;
using A4S.ERP.Infra.Data.Mapping;
=======
﻿using Coladel.GerenciadorAulas.Domain.Entidades;
using Coladel.GerenciadorPedidos.Domain.Entidades;
using Coladel.GerenciadorPedidos.Infra.Data.Mapping;
using Coladel.Infra.Data.Mapping;
using Microsoft.AspNetCore.Http;
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6
using Microsoft.EntityFrameworkCore;

namespace A4S.ERP.Infra.Data
{
    public class UserDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<BdEmpresa> BdEmpresa { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Certificado> Certificado { get; set; }
        public DbSet<Tributos> Tributos { get; set; }
        public DbSet<ContatoUser> ContatoUser { get; set; }

<<<<<<< HEAD
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TributosMapping());
            modelBuilder.ApplyConfiguration(new EmpresaMapping());
            modelBuilder.ApplyConfiguration(new ContatoUserMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new BdEmpresaMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new RoleMapping());
            modelBuilder.ApplyConfiguration(new SetorMapping());
            modelBuilder.ApplyConfiguration(new CertificadoMapping());
=======
        public DbSet<Email> Email { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<EnvioEmail> EnvioEmail { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }
        public DbSet<Configuracoes> Configuracoes { get; set; }
        public DbSet<Transportadora> Transportadora { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> options, IHttpContextAccessor httpContext) : base(options)
        {
            _connectionString = httpContext.HttpContext.User.Claims.Where(p => p.Type == ClaimTypes.Uri).Select(p => p.Value).FirstOrDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString != null)
                optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString), b => b.MigrationsAssembly("Coladel.GerenciadorPedidos"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmailMapping());
            modelBuilder.ApplyConfiguration(new EmpresaMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new PedidosMapping());
            modelBuilder.ApplyConfiguration(new ContatoMapping());
            modelBuilder.ApplyConfiguration(new TelefoneMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new EnvioEmailMapping());
            modelBuilder.ApplyConfiguration(new ItensPedidoMapping());
            modelBuilder.ApplyConfiguration(new ConfiguracoesMapping());
            modelBuilder.ApplyConfiguration(new TransportadoraMapping());
>>>>>>> 0d898aa9a598847d35bd4a65ea35f8eb6f5798b6

            base.OnModelCreating(modelBuilder);
        }
    }
}
