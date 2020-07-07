using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColitaWeb.DataAccess
{
    public class GenericResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
    }
}
