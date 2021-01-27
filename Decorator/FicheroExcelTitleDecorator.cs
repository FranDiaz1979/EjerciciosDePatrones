using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Decorator
{
    class FicheroExcelTitleDecorator : IFicheroExcelDecorator
    {
        public FileStream File { get; set; }
        public FicheroExcelFormatting Formatting { get; set; }
        public FicheroExcelTitleDecorator(IFicheroExcelDecorator ficheroExcelDecorator)
        {
            this.File = ficheroExcelDecorator.File;
            this.Formatting = ficheroExcelDecorator.Formatting;

            // Formatea la cabecera de la pagina (fila 1 más ancha, con 1 color, con titulo en letra más grande, etc.)
            Console.WriteLine(" Añadido titulo: " + ficheroExcelDecorator.Formatting.Title);
            Console.WriteLine(" Añadido color al titulo: " + ficheroExcelDecorator.Formatting.TitleColor.Name);
        }
    }
}
