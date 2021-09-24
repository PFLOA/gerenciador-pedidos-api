using Coladel.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Coladel.Core.Rest
{
    public class RestController : ControllerBase
    {
        protected async Task<IActionResult> Execute(Func<object> func)
        {
            try
            {
                var result = func.Invoke();

                if (result != null)
                {
                    if (result is IOperationResultBase)
                    {
                        return await CreateActionResult(result);
                    }
                }

                return await Task.FromResult(new OkResult());
            }
            catch (Exception ex)
            {
                return await Task.FromResult(new BadRequestObjectResult(ex.Message));
            }
        }

        private async Task<IActionResult> CreateActionResult(dynamic result)
        {
            var objectResult = new ObjectResult(result);
            objectResult.StatusCode = (int)result.ResultType;

            if (result.Messages.Count > 0)
            {
                return await Task.FromResult(RestStatusHttp.ReturnStatus(result.ResultType, new ResultData { Messages = result.Messages }));
            }

            return await Task.FromResult(RestStatusHttp.ReturnStatus(result.ResultType, new ResultData { Data = result.Data }));
        }
    }
}
