using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ValidarOrdenDeCobroStrategy : IValidadorStrategy
    {
        public bool Validar(Peticion peticion)
        {
            Console.WriteLine("Validar Orden De Cobro");
            return true;
        }
    }
}
