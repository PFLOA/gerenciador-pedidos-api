﻿using A4S.Core.Interfaces.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4S.Core.Models
{
    public class BaseFilter : IPagination
    {
        public int ItemsPerPage { get; set; } = 30;
        public bool CountTotal { get; set; }
        public IList<OrdenationAttribute> Ordenations { get; set; }
        public int Page { get; set; } = 1;
    }
}
