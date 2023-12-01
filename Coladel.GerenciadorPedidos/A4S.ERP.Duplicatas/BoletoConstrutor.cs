using A4S.ERP.Duplicatas.Model;
using BoletoNetCore;
using System;
using System.IO;
using System.Text;

namespace A4S.ERP.Duplicatas
{
    public class BoletoConstrutor
    {
        private readonly Pagador _pagador;
        private readonly IBanco _banco;

        public BoletoConstrutor(Beneficiario beneficiario, Pagador pagador)
        {
            _pagador = pagador;
            _banco = Banco.Instancia(Bancos.Santander);

            _banco.Beneficiario = beneficiario;

            _banco.FormataBeneficiario();
        }

        public ArquivosRemessa RetornoRemessa(string nossoNumero, string numeroDocumento, string duplicata, decimal multa, decimal jurosDia, decimal valorTitulo, DateTime dataVencimento)
        {
            var dataMulta = dataVencimento.AddDays(5);
            var dataJuros = dataVencimento.AddDays(6);

            var boletos = new Boletos();
            var arquivosRemessa = new ArquivosRemessa();

            var boleto = new Boleto(_banco)
            {
                DataVencimento = dataVencimento,
                ValorTitulo = valorTitulo,
                NossoNumero = nossoNumero,
                NumeroDocumento = numeroDocumento,
                TipoJuros = TipoJuros.Simples,
                TipoCodigoMulta = BoletoNetCore.Enums.TipoCodigoMulta.Percentual,
                CodigoProtesto = TipoCodigoProtesto.ProtestarDiasCorridos,
                DiasProtesto = 7,
                DataJuros = dataJuros,
                DataMulta = dataMulta,
                ImprimirValoresAuxiliares = true,
                ImprimirMensagemInstrucao = true,
                MensagemInstrucoesCaixa = $"COMISSAO DE PERMANENCIA AO DIA {((jurosDia/100) * valorTitulo).ToString("C")}\r\nCOBRAR MULTA DE {((multa / 100) * valorTitulo).ToString("C")} APOS {dataMulta.ToString("dd/MM/yyyy")}\r\nQUALQUER DUVIDA ENTRAR EM CONTATO COM A COLADEL 11 3141-1169 / 11 97387-9630\r\nPROTESTO APOS 6 DIAS DO VENCIMENTO\r\nDUPLICATA / NF {duplicata}",
                PercentualMulta = multa,
                PercentualJurosDia = jurosDia,
                EspecieDocumento = TipoEspecieDocumento.DM,
                Pagador = _pagador
            };

            boleto.ValidarDados();

            var remessa = new ArquivoRemessa(boleto.Banco, TipoArquivo.CNAB240, 1);

            boletos.Add(boleto);

            using (Stream stream = new MemoryStream())
            {
                remessa.GerarArquivoRemessa(boletos, stream, false);

                stream.Position = 0;

                StreamReader reader = new StreamReader(stream);
                string text = reader.ReadToEnd();

                byte[] bytes = Encoding.ASCII.GetBytes(text);

                arquivosRemessa.Remessa = Convert.ToBase64String(bytes);
            }

            foreach (var b in boletos)
            {
                var boletoBancario = new BoletoBancario() { Boleto = b };
                var html = boletoBancario.MontaHtmlEmbedded(false);

                byte[] bytes = Encoding.ASCII.GetBytes(html);

                arquivosRemessa.Boleto = html;
            }

            return arquivosRemessa;
        }
    }
}
