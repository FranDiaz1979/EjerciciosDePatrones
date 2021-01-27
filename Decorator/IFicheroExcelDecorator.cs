using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Decorator
{
    interface IFicheroExcelDecorator
    {
        public FileStream File { get; set; }
        public FicheroExcelFormatting Formatting { get; set; }
    }
}
