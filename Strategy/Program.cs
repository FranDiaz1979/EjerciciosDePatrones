using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            var validadorPeticiones = new ValidadorPeticiones();

            var peticion = new Peticion { TipoPeticion = TipoPeticion.FormaDePago };
            validadorPeticiones.Validar(peticion);

            peticion = new Peticion { TipoPeticion = TipoPeticion.OrdenDeCobro };
            validadorPeticiones.Validar(peticion);

            Console.Write("\n" +
                "Presione cualquier tecla para cerrar esta ventana...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
