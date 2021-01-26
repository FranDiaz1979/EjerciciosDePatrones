using System;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            var user = new User
            {
                Username = "Pepe",
                Password = "****",
                Street = @"c\ Pallars 2",
                IsAdmin = true
            };
            Console.WriteLine(user.Username);
            
            Console.Write("\n" +
                "Presione cualquier tecla para cerrar esta ventana...");
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}
