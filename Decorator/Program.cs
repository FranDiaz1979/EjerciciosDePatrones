using System;
using System.IO;

namespace Decorator
{
    class Program
    {
        static void Main()
        {
            FileStream file = File.Create("FilePath");
            var utilidadesExcel = new UtilidadesExcel();
            utilidadesExcel.GenerarFichero(file, "select * from clients where active=1", "Listado de clientes");

            Console.WriteLine("Fichero creado");

            Console.Write("\n" +
                "Presione cualquier tecla para cerrar esta ventana...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
