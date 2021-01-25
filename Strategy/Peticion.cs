using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public enum TipoPeticion
    {
        FormaDePago,
        OrdenDeCobro
    }

    public class Peticion
    {
        public TipoPeticion TipoPeticion { get; set; }
    }
}
