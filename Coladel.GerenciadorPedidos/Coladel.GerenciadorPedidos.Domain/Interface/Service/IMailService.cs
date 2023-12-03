using A4S.ERP.Domain.Body;

namespace A4S.ERP.Domain.Interface.Service
{
    public interface IMailService
    {
        void SendEmail(EmailRequestBody mailRequest);
    }
}
