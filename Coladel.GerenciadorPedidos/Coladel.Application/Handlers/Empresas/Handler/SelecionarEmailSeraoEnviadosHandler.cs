﻿using A4S.Application.Handlers.Empresas.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using System;

namespace A4S.Application.Handlers.Empresas.Handler
{
    public class SelecionarEmailSeraoEnviadosHandler : IRequestHandler<SelecionarEmailSeraoEnviadosRequest, IActionResult>
    {
        public Task<IActionResult> Handle(SelecionarEmailSeraoEnviadosRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
