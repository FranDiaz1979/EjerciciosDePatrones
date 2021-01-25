using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ValidarFormaDePagoStrategy : IValidadorStrategy
    {
        public bool Validar(Peticion peticion)
        {
            Console.WriteLine("Validar Forma De Pago");
            return true;
        }
    }
}
