using A4S.ERP.Domain.Body;
using A4S.ERP.Domain.Interface.Service;
using A4S.ERP.Domain.Servicos;
using Microsoft.Extensions.Options;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace A4S.ERP.Application.Services
{
    public class MailService : IMailService
    {
        private readonly EmailSettings _mailSettings;
        public MailService(IOptions<EmailSettings> emailSettings)
        {
            _mailSettings = emailSettings.Value;
        }

        public void SendEmail(EmailRequestBody mailRequest)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();

            string corpo = string.Format("<!DOCTYPE html><html lang=en><head> <meta charset=UTF-8> <meta name=viewport content=\"width=device-width, initial-scale=1.0\"> <title>nfe</title> <style>body{{font-family:'Courier New',Courier,monospace}}</style></head><body> <p> Olá, </p><p>{0}</p> <table style=font-size:small;font-family:Verdana class=\"table_StyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr> <td> <table style=font-size:small;font-family:Verdana class=\"tableStyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr> <td style=vertical-align:middle> <h2 color=#000000 style=margin:0;font-size:16px;color:#000;font-weight:600 class=\"nameNameContainer-sc-1m457h3-0 jxbGUj\"> <span>Paulo</span><span>&nbsp;</span><span>Fernando</span> </h2> <p color=#000000 font-size=small style=margin:0;color:#000;font-size:12px;line-height:20px class=\"job-titleContainer-sc-1hmtp73-0 ifJNJc\"> <span>Auxiliar de Vendas</span> </p> <p color=#000000 font-size=small style=margin:0;font-weight:500;color:#000;font-size:12px;line-height:20px class=\"company-detailsCompanyContainer-sc-j5pyy8-0 VnOLK\"><span>Vendas</span><span>&nbsp;|&nbsp;</span><span>COLADEL</span> </p> </td> <td width=30><div style=width:30px></div></td> <td color=#f25597 direction=vertical style=\"width:1px;border-bottom:medium none;border-left:1px solid #f25597\" class=\"color-dividerDivider-sc-1h38qjv-0 llIisW\" width=1 height=auto></td> <td width=30><div style=width:30px></div></td> <td style=vertical-align:middle> <table style=font-size:small;font-family:Verdana class=\"tableStyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr style=vertical-align:middle height=25> <td style=vertical-align:middle width=30> <table style=font-size:small;font-family:Verdana class=\"tableStyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr> <td style=vertical-align:bottom> <span color=#f25597 width=11 style=display:inline-block;background-color:#f25597 class=\"contact-infoIconWrapper-sc-mmkjr6-1 bglVXe\"><img src=\"https://cdn2.hubspot.net/hubfs/53/tools/email-signature-generator/icons/phone-icon-2x.png\" color=#f25597 alt=mobilePhone style=display:block;background-color:#f25597 class=\"contact-infoContactLabelIcon-sc-mmkjr6-0 cnkwri\" width=13 /></span> </td> </tr> </tbody> </table> </td> <td style=padding:0;color:#000000> <a href=\"tel:11 3141 1169\" color=#000000 style=text-decoration:none;color:#000;font-size:12px class=\"contact-infoExternalLink-sc-mmkjr6-2 ibLXSU\"><span>11 3141 1169</span></a> | <a href=\"tel:11 97387 9630\" color=#000000 style=text-decoration:none;color:#000;font-size:12px class=\"contact-infoExternalLink-sc-mmkjr6-2 ibLXSU\"><span>11 97397 9630</span></a> </td> </tr> <tr style=vertical-align:middle height=25> <td style=vertical-align:middle width=30> <table style=font-size:small;font-family:Verdana class=\"tableStyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr> <td style=vertical-align:bottom> <span color=#f25597 width=11 style=display:inline-block;background-color:#f25597 class=\"contact-infoIconWrapper-sc-mmkjr6-1 bglVXe\"><img src=\"https://cdn2.hubspot.net/hubfs/53/tools/email-signature-generator/icons/email-icon-2x.png\" color=#f25597 alt=emailAddress style=display:block;background-color:#f25597 class=\"contact-infoContactLabelIcon-sc-mmkjr6-0 cnkwri\" width=13 /></span> </td> </tr> </tbody> </table> </td> <td style=padding:0> <a href=\"mailto:vendas@coladel.com.br\" color=#000000 style=text-decoration:none;color:#000;font-size:12px class=\"contact-infoExternalLink-sc-mmkjr6-2 ibLXSU\"><span>vendas@coladel.com.br</span></a> </td> </tr> <tr style=vertical-align:middle height=25> <td style=vertical-align:middle width=30> <table style=font-size:small;font-family:Verdana class=\"tableStyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr> <td style=vertical-align:bottom> <span color=#f25597 width=11 style=display:inline-block;background-color:#f25597 class=\"contact-infoIconWrapper-sc-mmkjr6-1 bglVXe\"><img src=\"https://cdn2.hubspot.net/hubfs/53/tools/email-signature-generator/icons/link-icon-2x.png\" color=#f25597 alt=website style=display:block;background-color:#f25597 class=\"contact-infoContactLabelIcon-sc-mmkjr6-0 cnkwri\" width=13 /></span> </td> </tr> </tbody> </table> </td> <td style=padding:0> <a href=//www.coladel.com.br color=#000000 style=text-decoration:none;color:#000;font-size:12px class=\"contact-infoExternalLink-sc-mmkjr6-2 ibLXSU\"><span>www.coladel.com.br</span></a> </td> </tr> <tr style=vertical-align:middle height=25> <td style=vertical-align:middle width=30> <table style=font-size:small;font-family:Verdana class=\"tableStyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr> <td style=vertical-align:bottom> <span color=#f25597 width=11 style=display:inline-block;background-color:#f25597 class=\"contact-infoIconWrapper-sc-mmkjr6-1 bglVXe\"><img src=\"https://cdn2.hubspot.net/hubfs/53/tools/email-signature-generator/icons/address-icon-2x.png\" color=#f25597 alt=address style=display:block;background-color:#f25597 class=\"contact-infoContactLabelIcon-sc-mmkjr6-0 cnkwri\" width=13 /></span> </td> </tr> </tbody> </table> </td> <td style=padding:0> <span color=#000000 style=font-size:12px;color:#000000 class=\"contact-infoAddress-sc-mmkjr6-3 jxDmGK\"><span>Av. Paulista 671</span></span> </td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> <tr> <td> <table style=width:100%;font-size:small;font-family:Verdana class=\"tableStyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr> <td height=30></td> </tr> <tr> <td color=#f25597 direction=horizontal style=\"width:100%;border-bottom:1px solid #f25597;border-left:medium none;display:block\" class=\"color-dividerDivider-sc-1h38qjv-0 llIisW\" width=auto height=1></td> </tr> <tr> <td height=30></td> </tr> </tbody> </table> </td> </tr> <tr> <td> <table style=width:100%;font-size:small;font-family:Verdana class=\"tableStyledTable-sc-1avdl6r-0 kAbRZI\" cellspacing=0 cellpadding=0> <tbody> <tr> <td style=vertical-align:top></td> </tr> </tbody> </table> </td> </tr> </tbody></table><p style=font-size:12px> Enviado por Advanced 4 Softwares, controle de notas fiscais e automatização de processos.</p></body></html>", mailRequest.Body);

            message.From = new MailAddress(_mailSettings.Mail, _mailSettings.DisplayName);
            message.To.Add(new MailAddress(mailRequest.ToEmail));
            message.Subject = mailRequest.Subject;

            if (mailRequest.Attachments != null)
            {
                foreach (var file in mailRequest.Attachments)
                {
                    if (file.Length > 0)
                    {
                        using (var ms = new MemoryStream())
                        {
                            file.CopyTo(ms);
                            var fileBytes = ms.ToArray();
                            Attachment att = new Attachment(new MemoryStream(fileBytes), file.FileName);
                            message.Attachments.Add(att);
                        }
                    }
                }
            }

            message.IsBodyHtml = true;
            message.Body = corpo;
            smtp.Port = _mailSettings.Port;
            smtp.Host = _mailSettings.Host;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(_mailSettings.Mail, _mailSettings.Password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);
        }
    }
}
