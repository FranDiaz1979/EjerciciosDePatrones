using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args) 
        {
            var validadorPeticiones = new ValidadorPeticiones();

            validadorPeticiones.SetStrategy(new ValidarFormaDePagoStrategy());
            var peticion = new Peticion { TipoPeticion = TipoPeticion.FormaDePago };
            validadorPeticiones.Validar(peticion);

            validadorPeticiones.SetStrategy(new ValidarOrdenDeCobroStrategy());
            peticion = new Peticion { TipoPeticion = TipoPeticion.OrdenDeCobro };
            validadorPeticiones.Validar(peticion);

            Console.Write("\n" +
                "Presione cualquier tecla para cerrar esta ventana...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
