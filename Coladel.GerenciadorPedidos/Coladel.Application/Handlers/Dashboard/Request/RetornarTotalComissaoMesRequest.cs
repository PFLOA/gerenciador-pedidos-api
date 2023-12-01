using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace A4S.Application.Handlers.Dashboard.Request
{
    public class RetornarTotalComissaoMesRequest : IRequest<IActionResult>
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
    }
}
