using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Enum;
using A4S.ERP.Domain.Filters;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Infra.Data;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;

namespace A4S.ERP.Infra.Repository
{
    public class TransportadoraRepository : Repository<Transportadora>, ITransportadoraRepository
    {
        public TransportadoraRepository(AppDbContext dbContext) : base(dbContext) { }

        public IQueryable<Transportadora> BuscarTransportadoraPorFiltro(BuscarTransportadoraFilter filter)
        {
            return Set.Include(x => x.Endereco).AsQueryable();
        }

        public void Importar(Stream csv)
        {
            StreamReader sr = new StreamReader(csv);

            while (sr.Peek() >= 0)
            {
                string[] campos = sr.ReadLine().Split(';');

                var found = Set.FirstOrDefault(x => x.CodTransportadora == campos[0]);

                if (found == null)
                {
                    var transportadora = new Transportadora
                    {
                        Cnpj = campos[12],
                        InscricaoEstadual = campos[13],
                        NomeFantasia = campos[20],
                        Observacao = campos[14],
                        RazaoSocial = campos[3],
                        TipoPessoa = TipoPessoa.JURIDICA,
                        Website = campos[19],
                        Endereco = new Endereco
                        {
                            Cep = campos[6],
                            Bairro = campos[5],
                            Cidade = campos[7],
                            Complemento = campos[23],
                            Estado = campos[8],
                            Logradouro = campos[4]
                        },
                        Contato = new Contato
                        {
                            Email = campos[15],
                            Celular = campos[22],
                            Telefone = campos[9]
                        }
                    };

                    Set.Add(transportadora);

                    context.SaveChanges();
                }
            }
        }
    }
}
