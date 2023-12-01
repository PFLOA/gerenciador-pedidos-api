using A4S.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4S.Core.Interfaces.Results
{
    public interface IOrderable
    {
        IList<OrdenationAttribute> Ordenations { get; set; }
    }
}
