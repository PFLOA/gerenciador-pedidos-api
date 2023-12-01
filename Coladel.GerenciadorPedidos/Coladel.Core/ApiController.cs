using System;
using System.Threading.Tasks;
using A4S.Core.Rest;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace A4S.Core
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ApiController : RestController
    {
        protected readonly IMediator _mediator;

        public ApiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected async Task<IActionResult> Executar(Func<Task<object>> funcao)
        {
            return await ExecuteAsync(funcao);
        }
    }
}
