using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Entidades.Response;
using System;

namespace A4S.Application.Handlers.Transportadoras.Response
{
    public class BuscarTransportadoraPorFiltroResponse
    {
        public DateTime DataCadastro { get; set; }
        public Guid Guid { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }

        public EnderecoResponse Endereco { get; set; }

        public BuscarTransportadoraPorFiltroResponse(Transportadora transportadora)
        {
            DataCadastro = transportadora.DataCadastro;
            Guid = transportadora.Guid;
            RazaoSocial = transportadora.RazaoSocial;
            Cnpj = transportadora.Cnpj;
            InscricaoEstadual = transportadora.InscricaoEstadual;

            Endereco = new EnderecoResponse(transportadora.Endereco);
        }
    }
}
