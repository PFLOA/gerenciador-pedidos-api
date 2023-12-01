using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace A4S.ERP.Servicos
{
    public class CobrancaDuplicatasServico : BackgroundService
    {
        ILogger<CobrancaDuplicatasServico> _logger;

        public CobrancaDuplicatasServico(ILogger<CobrancaDuplicatasServico> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogWarning("Serviço de Cobrança de Boletos !");

                Task.Delay(60000).Wait();
            }
        }
    }
}
