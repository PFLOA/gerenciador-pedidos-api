using A4S.ERP.Domain.Entidades;
using A4S.ERP.Infra.Data.Mapping;
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

            base.OnModelCreating(modelBuilder);
        }
    }
}
