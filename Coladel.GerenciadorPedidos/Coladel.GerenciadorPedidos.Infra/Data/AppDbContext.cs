using A4S.ERP.Domain.Entidades;
using A4S.ERP.Infra.Data.Mapping;
using A4S.ERP.Infra.Data.Mapping.AppDb;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;

namespace A4S.ERP.Infra.Data
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Remessas> Remessas { get; set; }
        public DbSet<ContasReceber> ContasReceber { get; set; }
        public DbSet<ControleBoletos> ControleBoletos { get; set; }
        public DbSet<Transportadora> Transportadora { get; set; }
        public DbSet<TransporteNf> TransporteNf { get; set; }
        public DbSet<NotaFiscal> NotaFiscal { get; set; }
        public DbSet<CobrancaNf> CobrancaNf { get; set; }
        public DbSet<ItensNotaFiscal> ItensNotaFiscal { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<EnvioEmail> EnvioEmail { get; set; }
        public DbSet<ItensPedido> ItensPedido { get; set; }
        public DbSet<Configuracoes> Configuracoes { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Tributos> Tributos { get; set; }
        public DbSet<Cor> Cor { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<InformacoesFiscais> InformacoesFiscais { get; set; }
        public DbSet<ContatoCliente> ContatoCliente { get; set; }
        public DbSet<GrupoProduto> GrupoProduto { get; set; }
        public DbSet<SubGrupoProduto> SubGrupoProduto { get; set; }
        public DbSet<Embalagem> Embalagem { get; set; }
        public DbSet<Unidades> Unidades { get; set; }
        public DbSet<BdEmpresa> BdEmpresa { get; set; }
        public DbSet<RamoAtividade> RamoAtividade { get; set; }
        public DbSet<PlanoContas> PlanoContas { get; set; }
        public DbSet<CondicoesPagamento> CondicoesPagamento { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Banco> Banco { get; set; }
        public DbSet<TipoCliente> TipoCliente { get; set; }
        public DbSet<Parcelas> Parcelas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor httpContext) : base(options) => 
            _connectionString = httpContext.HttpContext.User.Claims.Where(p => p.Type == ClaimTypes.Uri).Select(p => p.Value).FirstOrDefault();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionString != null)
                optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString), b => b.MigrationsAssembly("A4S.ERP"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CorMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new RemessasMapping());
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new ModeloMapping());
            modelBuilder.ApplyConfiguration(new PedidosMapping());
            modelBuilder.ApplyConfiguration(new ContatoMapping());
            modelBuilder.ApplyConfiguration(new ContatosClientesMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new UnidadesMapping());
            modelBuilder.ApplyConfiguration(new TributosMapping());
            modelBuilder.ApplyConfiguration(new EmbalagemMapping());
            modelBuilder.ApplyConfiguration(new EnvioEmailMapping());
            modelBuilder.ApplyConfiguration(new NotaFiscalMapping());
            modelBuilder.ApplyConfiguration(new ControleBoletosMapping());
            modelBuilder.ApplyConfiguration(new FornecedorMapping());
            modelBuilder.ApplyConfiguration(new CobrancaNfMapping());
            modelBuilder.ApplyConfiguration(new ItensPedidoMapping());
            modelBuilder.ApplyConfiguration(new TransporteNfMapping());
            modelBuilder.ApplyConfiguration(new GrupoProdutoMapping());
            modelBuilder.ApplyConfiguration(new ContasReceberMapping());
            modelBuilder.ApplyConfiguration(new ConfiguracoesMapping());
            modelBuilder.ApplyConfiguration(new TransportadoraMapping());
            modelBuilder.ApplyConfiguration(new SubGrupoProdutoMapping());
            modelBuilder.ApplyConfiguration(new ItensNotaFiscalMapping());
            modelBuilder.ApplyConfiguration(new OrigemMercadoriaMapping());
            modelBuilder.ApplyConfiguration(new InformacoesFiscaisMapping());
            modelBuilder.ApplyConfiguration(new RamoAtividadeMapping());
            modelBuilder.ApplyConfiguration(new ContaMapping());
            modelBuilder.ApplyConfiguration(new BancoMapping());
            modelBuilder.ApplyConfiguration(new PlanoContasMapping());
            modelBuilder.ApplyConfiguration(new CondicoesPagamentoMapping());
            modelBuilder.ApplyConfiguration(new MeioPagamentoMapping());
            modelBuilder.ApplyConfiguration(new TipoClienteMapping());
            modelBuilder.ApplyConfiguration(new ParcelasMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
