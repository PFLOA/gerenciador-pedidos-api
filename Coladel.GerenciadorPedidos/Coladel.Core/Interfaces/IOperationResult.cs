using Coladel.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coladel.Core.Interfaces
{
    public interface IOperationResultBase
    {
        List<string> Messages { get; set; }
        EnumTypeResult ResultType { get; set; }
        Exception Exception { get; set; }
        bool IsSuccessTypeResult { get; }
        IOperationResultBase AddMessage(string message);
    }
    public interface IOperationResult<T> : IOperationResultBase
    {
        T Data { get; set; }
        new IOperationResult<T> AddMessage(string message);
    }
}
