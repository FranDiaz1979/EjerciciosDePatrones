using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Decorator
{
    class FicheroExcelSolidBackgroundDecorator : IFicheroExcelDecorator
    {
        public FileStream File { get; set; }
        public FicheroExcelFormatting Formatting { get; set; }
        public FicheroExcelSolidBackgroundDecorator(IFicheroExcelDecorator ficheroExcelDecorator)
        {
            this.File = ficheroExcelDecorator.File;
            this.Formatting = ficheroExcelDecorator.Formatting;

            // Pone el color de fondo elegido desde la fila 2 en adelante
            Console.WriteLine(" Añadido color de fondo: " + ficheroExcelDecorator.Formatting.BackgroundColor.Name);
        }
    }
}
