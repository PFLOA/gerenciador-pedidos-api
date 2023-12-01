using A4S.ERP.Application.Handlers.ContasRecebers.Request;
using A4S.ERP.Domain.Entidades;
using A4S.ERP.Domain.Interface;
using A4S.ERP.Duplicatas;
using BoletoNetCore;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Application.Handlers.ContasRecebers.Handlers
{
    public class GerarBoletoHandler : IRequestHandler<GerarBoletoRequest, IActionResult>
    {
        private Beneficiario _beneficiario;
        private IBanco _banco;

        private readonly ControleBoletos _controleBoletos;

        private readonly IContasReceberRepository _contasReceberRepository;
        private readonly IRemessasRepository _remessasRepository;
        private readonly IControleBoletosRepository _controleBoletosRepository;

        public GerarBoletoHandler(IContasReceberRepository contasReceberRepository, IControleBoletosRepository controleBoletos, IRemessasRepository remessasRepository)
        {
            _controleBoletos = controleBoletos.BuscarControleBoletos();
            _controleBoletosRepository = controleBoletos;
            _contasReceberRepository = contasReceberRepository;
            _remessasRepository = remessasRepository;

            var contaBancaria = new ContaBancaria
            {
                Agencia = "0236",
                DigitoAgencia = "0",
                Conta = "13002723",
                DigitoConta = "3",
                CarteiraPadrao = "101",
                TipoCarteiraPadrao = TipoCarteira.CarteiraCobrancaSimples,
                TipoFormaCadastramento = TipoFormaCadastramento.ComRegistro,
                TipoImpressaoBoleto = TipoImpressaoBoleto.Empresa
            };

            _beneficiario = new Beneficiario
            {
                CPFCNPJ = "05.480.442/0001-04",
                Nome = "COLADEL COMERCIO DE EMBALAGENS LTDA ME",
                Codigo = "8715947",
                CodigoDV = "",
                CodigoTransmissao = "023600008715947",
                Endereco = new BoletoNetCore.Endereco
                {
                    LogradouroEndereco = "Av Paulista",
                    LogradouroNumero = "671",
                    LogradouroComplemento = "",
                    Bairro = "Bela Vista",
                    Cidade = "São Paulo",
                    UF = "SP",
                    CEP = "01311-100"
                },
                ContaBancaria = contaBancaria
            };
        }

        public async Task<IActionResult> Handle(GerarBoletoRequest request, CancellationToken cancellationToken)
        {
            Duplicatas.Model.ArquivosRemessa arquivosRemessa;

            try
            {
                ContasReceber cr = _contasReceberRepository.BuscarPorGuid(request.Guid);

                if (cr is null) return await Task.FromResult(new NotFoundResult());

                var remessas = _remessasRepository.BuscarRemessaPorIdContasReceber(cr.Id);

                if (remessas == null)
                {
                    var pagador = new Pagador
                    {
                        CPFCNPJ = cr.Cliente.DocumentoPrincipal,
                        Nome = cr.Cliente.RazaoSocial,
                        Endereco = new BoletoNetCore.Endereco
                        {
                            LogradouroEndereco = cr.Cliente.Endereco.Logradouro,
                            LogradouroNumero = cr.Cliente.Endereco.Numero,
                            LogradouroComplemento = "",
                            Bairro = cr.Cliente.Endereco.Bairro,
                            Cidade = cr.Cliente.Endereco.Cidade,
                            UF = cr.Cliente.Endereco.Estado,
                            CEP = cr.Cliente.Endereco.Cep
                        }
                    };

                    BoletoConstrutor boletoConstrutor = new BoletoConstrutor(_beneficiario, pagador);

                    arquivosRemessa = boletoConstrutor.RetornoRemessa(_controleBoletos.NossoNumeroFormatado, _controleBoletos.NumeroDocumento, cr.Duplicata, cr.Multa, cr.JurosDia, cr.ValorBruto, cr.DataVencimento);

                    new Regex("(\r\n|\r|\n)").Replace(arquivosRemessa.Boleto, "");
                    _remessasRepository.Criar(new Remessas
                    {
                        ClienteId = cr.Cliente.Id,
                        ContasReceberId = cr.Id,
                        HtmlBoleto = new Regex("(\r\n|\r|\n)").Replace(arquivosRemessa.Boleto, ""),
                        ArquivoRemessa = arquivosRemessa.Remessa
                    });

                    _controleBoletos.NossoNumero += 1;
                    _controleBoletosRepository.Alterar(_controleBoletos);
                }
                else
                {
                    arquivosRemessa = new Duplicatas.Model.ArquivosRemessa
                    {
                        Boleto = remessas.HtmlBoleto,
                        Remessa = remessas.ArquivoRemessa
                    };
                }

                return await Task.FromResult(new OkObjectResult(arquivosRemessa));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { Errors = new[] { $"{ex.Message}" } }));
            }
        }
    }
}
