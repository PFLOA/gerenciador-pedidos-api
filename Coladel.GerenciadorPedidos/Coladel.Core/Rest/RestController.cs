﻿using A4S.Core.Interfaces;
using A4S.Core.Interfaces.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace A4S.Core.Rest
{
    public class RestController : ControllerBase
    {
        protected async Task<IActionResult> ExecuteAsync(Func<Task<object>> func)
        {
            try
            {
                var result = await func.Invoke();

                if (result != null)
                {
                    if (result is IOperationResultBase)
                    {
                        return await CreateActionResult(result);
                    }

                    if (result is IPaginatedResult)
                    {
                        return await CreateActionResult(result);
                    }
                }

                return await Task.FromResult(new BadRequestObjectResult(new { Error = "Erro interno do servidor" }));
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(ex.Message));
            }
        }

        private async Task<IActionResult> CreateActionResult(dynamic result)
        {
            _ = new ObjectResult(result)
            {
                StatusCode = (int)result.ResultType
            };

            if (result.Messages.Count > 0)
            {
                return await Task.FromResult(RestStatusHttp.ReturnStatus(result.ResultType, new ResultData { Messages = result.Messages }));
            }

            return await Task.FromResult(RestStatusHttp.ReturnStatus(result.ResultType, new ResultData { Data = result.Data }));
        }
    }
}
