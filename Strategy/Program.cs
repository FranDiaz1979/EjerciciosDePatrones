using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var validadorPeticiones = new ValidadorPeticiones();

            var peticion = new Peticion { TipoPeticion = TipoPeticion.FormaDePago };
            validadorPeticiones.Validar(peticion);

            peticion = new Peticion { TipoPeticion = TipoPeticion.OrdenDeCobro };
            validadorPeticiones.Validar(peticion);
        }
    }
}
