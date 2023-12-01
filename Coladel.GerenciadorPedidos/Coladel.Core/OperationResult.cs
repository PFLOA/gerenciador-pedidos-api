using A4S.Core.Enum;
using A4S.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace A4S.Core
{
    public class OperationResult<TResult> : IOperationResult<TResult>
    {
        public TResult Data { get; set; }
        public List<string> Messages { get; } = new List<string>();
        public EnumTypeResult ResultType { get; set; }
        public Exception Exception { get; set; }

        public OperationResult(TResult data, EnumTypeResult result)
        {
            Data = data;
            ResultType = result;
        }
        public OperationResult(EnumTypeResult result)
        {
            ResultType = result;
        }
        public IOperationResult<TResult> AddMessage(string message)
        {
            Messages.Add(message);
            return this;
        }
        public static OperationResult<TResult> Create(EnumTypeResult result, TResult data)
        {
            return new OperationResult<TResult>(data, result);
        }
        public static OperationResult<TResult> Create(EnumTypeResult result)
        {
            return new OperationResult<TResult>(result);
        }
    }
}

