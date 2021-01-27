using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Decorator
{
    class FicheroExcelHeadersDecorator : IFicheroExcelDecorator
    {
        public FileStream File { get; set; }
        public FicheroExcelFormatting Formatting { get; set; }
        public FicheroExcelHeadersDecorator(IFicheroExcelDecorator ficheroExcelDecorator)
        {
            this.File = ficheroExcelDecorator.File;
            this.Formatting = ficheroExcelDecorator.Formatting;

            // Formatea los titulos de los campos (fila 2 en negrita con fondo de 1 color)
            Console.WriteLine(" Añadido headers de color: " + ficheroExcelDecorator.Formatting.HeadersColor.Name);
        }
    }
}
