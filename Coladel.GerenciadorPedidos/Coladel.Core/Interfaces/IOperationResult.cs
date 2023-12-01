using A4S.Core.Enum;
using System;
using System.Collections.Generic;

namespace A4S.Core.Interfaces
{
    public interface IOperationResultBase
    {
        List<string> Messages { get; }
        EnumTypeResult ResultType { get; set; }
        Exception Exception { get; set; }
    }
    public interface IOperationResult<T> : IOperationResultBase
    {
        T Data { get; set; }
        IOperationResult<T> AddMessage(string message);
    }
}
