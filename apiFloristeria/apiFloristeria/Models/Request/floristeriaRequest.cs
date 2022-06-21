using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiFloristeria.Models.Request
{
    public class floristeriaRequest
    {
        public string nombreFlor { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public int Estado { get; set; }

    }
}