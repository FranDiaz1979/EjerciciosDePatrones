namespace Decorator
{
    using System;
    using System.IO;

    class FicheroExcel
    {
        private string extension;
        private FileStream file;

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

        //Este método no está integrado en la creación de la clase porque esta clase sirve para ficheros que existan
        public void GenerarFichero(FicheroExcelFormatting formatting)
        {
            if (formatting.QuerySQL==null)
            {
                throw new ArgumentException(nameof(formatting.QuerySQL));
            }
            if (formatting.Title == null)
            {
                throw new ArgumentException(nameof(formatting.Title));
            }

            var data = Utilidades.RequestDataBase(formatting.QuerySQL);

            CreateExcelFile();
            FillExcelFile(data);
            FormatExcelFile(formatting);
        }

        private void CreateExcelFile()
        {
            string filename = this.Path + this.FileName + "." + this.Extension;
            if (File.Exists(filename))
            {
                throw new Exception("El fichero ya existe");
            }

            // Es un ejemplo, no quiero crear el fichero
            // this.file = File.Create(filename);
        }

        private void FillExcelFile(Object data)
        {
            data.ToString();
        }

        private void FormatExcelFile(FicheroExcelFormatting formatting)
        {
            IFicheroExcelDecorator fichero = new FicheroExcelDecorator(file, formatting);
            fichero = new FicheroExcelTitleDecorator(fichero);
            if (formatting.Alternate)
            { 
                fichero = new FicheroExcelAlternateBackgroundDecorator(fichero);
            }
            else
            {
                fichero = new FicheroExcelSolidBackgroundDecorator(fichero);
            }
            fichero = new FicheroExcelHeadersDecorator(fichero);

            // etc. (he borrado 4 líneas más que hace mi libreria de excels)
        }
    }
}
