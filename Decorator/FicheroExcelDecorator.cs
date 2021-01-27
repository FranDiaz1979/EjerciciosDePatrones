using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Decorator
{
    class FicheroExcelDecorator : IFicheroExcelDecorator
    {
        public FileStream File { get; set; }
        public FicheroExcelFormatting Formatting { get; set; }

        public FicheroExcelDecorator(FileStream file, FicheroExcelFormatting formatting)
        {
            this.File = file;
            this.Formatting = formatting;
        }
    }
}
