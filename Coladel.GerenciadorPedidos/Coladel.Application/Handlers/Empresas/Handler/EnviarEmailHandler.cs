using Coladel.Application.Handlers.Empresas.Request;
using Coladel.GerenciadorAulas.Domain.Interface;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using System.Net.Mail;
using System.Linq;
using System.Net;
using System.IO;
using MediatR;
using System;
using Coladel.GerenciadorAulas.Domain.Enum;
using Coladel.GerenciadorAulas.Domain.Entidades;

namespace Coladel.Application.Handlers.Empresas.Handler
{
    public class EnviarEmailHandler : IRequestHandler<EnviarEmailRequest, IActionResult>
    {
        private readonly IEmpresaRepository _empresaRepository;

        public EnviarEmailHandler(IEmpresaRepository empresaRepository) => _empresaRepository = empresaRepository;

        public async Task<IActionResult> Handle(EnviarEmailRequest request, CancellationToken cancellationToken)
        {

            try
            {
                IActionResult retorno = new OkResult();

                var empresa = _empresaRepository.RetornarEmpresa();

                if (empresa.Configuracoes.EnviarEmailLogistica) retorno = await EnvioEmail(request, empresa, TipoEmail.Logistica);
                if (empresa.Configuracoes.EnviarEmailTransportadora) retorno = await EnvioEmail(request, empresa, TipoEmail.Transportadora);

                return await Task.FromResult(retorno);
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(new { error = ex.Message }));
            }
        }

        private async Task<IActionResult> EnvioEmail(EnviarEmailRequest request, Empresa empresa, TipoEmail tipoEmail)
        {
            Attachment anexar;

            var email = empresa.EnvioEmails.FirstOrDefault(p => p.TipoEmail == tipoEmail && p.IsOrigem == true);
            var destinatarios = empresa.EnvioEmails.Where(p => p.TipoEmail == tipoEmail && p.IsOrigem == false).ToList();

            var msg = email.Mensagem.Replace("$cliente$", request.Cliente);
            msg = msg.Replace("$nf$", request.Nf);

            bool bValidaEmail = ValidaEnderecoEmail(destinatarios[0].Email);

            if (bValidaEmail == false)
                return await Task.FromResult(new BadRequestObjectResult(new { Error = "Email Inválido!" }));

            MailMessage mensagemEmail = new MailMessage(email.Email, destinatarios[0].Email, request.Cliente + " NF " + request.Nf, msg);
            mensagemEmail.IsBodyHtml = true;

            for (int i = 1; i < destinatarios.Count; i++)
            {
                mensagemEmail.Bcc.Add(destinatarios[i].Email);
            }

            byte[] bytes;

            if (request.File.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    request.File.CopyTo(memoryStream);
                    bytes = memoryStream.ToArray();
                }

                anexar = new Attachment(new MemoryStream(bytes), request.File.FileName, request.File.ContentType);

                mensagemEmail.Attachments.Add(anexar);
            }

            SmtpClient client = new SmtpClient(email.SmtpCliente, email.PortSmtp);
            client.UseDefaultCredentials = false;

            NetworkCredential cred = new NetworkCredential(email.Email, email.Senha);

            client.EnableSsl = true;
            client.Credentials = cred;

            client.Send(mensagemEmail);

            return await Task.FromResult(new OkObjectResult(new { OkResult = "Email Enviado !" }));
        }
        private static bool ValidaEnderecoEmail(string enderecoEmail)
        {
            try
            {
                string texto_Validar = enderecoEmail;
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                if (expressaoRegex.IsMatch(texto_Validar))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
