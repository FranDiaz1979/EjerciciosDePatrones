namespace Decorator
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Patrón Decorator\n");

            var excelFile = new FicheroExcel
            {
                Path = @"c:\docs\",
                FileName = DateTime.Now.ToShortDateString() + "_ListadoDeClientes",
                Extension = "xls",
            };

            excelFile.GenerarFichero("select * from clients where active=1", "Listado de clientes");

            Console.WriteLine("Fichero creado");

            Console.Write("\n" +
                "Presione cualquier tecla para cerrar esta ventana...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
