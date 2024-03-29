﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace A4S.Core.Rest.Model
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class RestResult
    {
        public List<string> Messages { get; set; }
        public object Data { get; set; }


        public int? TotalCount { get; set; }
        public int? Pages { get; set; }

        public int? Count { get; set; }
        public int? Page { get; set; }
    }
}
