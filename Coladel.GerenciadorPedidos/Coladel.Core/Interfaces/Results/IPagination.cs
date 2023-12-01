using System;
using System.Collections.Generic;
using System.Text;

namespace A4S.Core.Interfaces.Results
{
    public interface IPagination : IOrderable
    {
        int ItemsPerPage { get; set; }
        int Page { get; set; }
        bool CountTotal { get; set; }
    }
}
