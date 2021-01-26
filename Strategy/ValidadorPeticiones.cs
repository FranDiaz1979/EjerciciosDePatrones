using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ValidadorPeticiones
    {
        public bool Validar(Peticion peticion)
        {
            switch (peticion.TipoPeticion)
            {
                case TipoPeticion.FormaDePago:
                    return ValidarFormaDePago(peticion);
                case TipoPeticion.OrdenDeCobro:
                    return ValidarOrdenDeCobro(peticion);
                default:
                    return false;
            }
        }

        private bool ValidarOrdenDeCobro(Peticion peticion)
        {
            Console.WriteLine("Validar Orden De Cobro");
            return true;
        }

        private bool ValidarFormaDePago(Peticion peticion)
        {
            Console.WriteLine("Validar Forma De Pago");
            return true;
        }

        /* Un método de validación por cada tipo de petición */
    }

}
