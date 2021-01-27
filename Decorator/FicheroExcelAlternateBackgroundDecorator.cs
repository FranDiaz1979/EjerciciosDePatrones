using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Decorator
{
    class FicheroExcelAlternateBackgroundDecorator : IFicheroExcelDecorator
    {
        public FileStream File { get; set; }
        public FicheroExcelFormatting Formatting { get; set; }
        public FicheroExcelAlternateBackgroundDecorator(IFicheroExcelDecorator ficheroExcelDecorator)
        {
            this.File = ficheroExcelDecorator.File;
            this.Formatting = ficheroExcelDecorator.Formatting;

            // A veces queremos que el fichero alterne linea en color con linea en blanco
            Console.WriteLine(" Añadido color de fondo alterno: " + ficheroExcelDecorator.Formatting.BackgroundColor.Name);
        }
    }
}
