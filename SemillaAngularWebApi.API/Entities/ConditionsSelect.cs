using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SemillaAngularWebApi.API.Entities
{
    public class ConditionsSelect
    {

        public string type { get; set; }
        public string campo { get; set; }
        public object value { get; set; }
        public string op { get; set; }
        public bool isMultiple { get; set; }
    }
}