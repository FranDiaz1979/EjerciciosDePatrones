namespace Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class FicheroExcel
    {
        private string extension;

        public string Path { get; set; }
        public string FileName { get; set; }
        public string Extension
        {
            get
            {
                return extension;
            }
            set
            {
                switch (value)
                {
                    case "xls":
                    case "xlsx":
                    case "xlsm": 
                        extension = value;
                        break;
                    default: throw new ArgumentException("La extension del fichero no es valida", nameof(Extension));
                }
            }
        }
    }
}
