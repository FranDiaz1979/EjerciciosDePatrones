namespace Decorator
{
    using System;

    class Program
    {
        static void Main()
        {
            //Console.WriteLine();
            Console.Title = "Patrón Decorator";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine();

            var excelFile = new FicheroExcel
            {
                Path = @"c:\docs\",
                FileName = DateTime.Now.ToShortDateString() + "_ListadoDeClientes",
                Extension = "xls",
            };

            var formatting = new FicheroExcelFormatting
            {
                QuerySQL = "select * from clients where active=1",
                Title = "Listado de clientes",
            };

            excelFile.GenerarFichero(formatting);

            Console.WriteLine();
            Console.WriteLine(" Fichero generado");
            Console.WriteLine();
            Console.Write(" Presione cualquier tecla para cerrar esta ventana...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
