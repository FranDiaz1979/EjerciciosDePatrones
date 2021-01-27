namespace Decorator
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Text;

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
            // Es un ejemplo, no quiero crear el fichero

            //string filename = this.Path + this.FileName + "." + this.Extension;
            //if (File.Exists(filename))
            //{
            //    throw new Exception("El fichero ya existe");
            //}

            //this.file = File.Create(filename);
        }

        private void FillExcelFile(Object data)
        {
        }

        private void FormatExcelFile(FicheroExcelFormatting formatting)
        {
            FormatExcelFileTitle(formatting);
            if (formatting.Alternate)
            { 
                FormatExcelFileAlternateBackground(formatting);
            }
            else
            {
                FormatExcelFileBackground(formatting);
            }
            FormatExcelFileHeaders(formatting);

            // etc. (he borrado 4 línea más que hace mi libreria de excels)
        }

        private void FormatExcelFileTitle(FicheroExcelFormatting formatting)
        {
            // Formatea la cabecera de la pagina (fila 1 más ancha, con 1 color, con titulo en letra más grande, etc.)
            Console.WriteLine(" Añadido titulo: "+ formatting.Title);
            Console.WriteLine(" Añadido color al titulo: " + formatting.TitleColor.Name);
        }
        private void FormatExcelFileBackground(FicheroExcelFormatting formatting)
        {
            // Pone el color de fondo elegido desde la fila 2 en adelante
            Console.WriteLine(" Añadido color de fondo: " + formatting.BackgroundColor.Name);
        }

        private void FormatExcelFileAlternateBackground(FicheroExcelFormatting formatting)
        {
            // A veces queremos que el fichero alterne linea en color con linea en blanco
            Console.WriteLine(" Añadido color de fondo alterno: " + formatting.BackgroundColor.Name);
        }

        private void FormatExcelFileHeaders(FicheroExcelFormatting formatting)
        {
            // Formatea los titulos de los campos (fila 2 en negrita con fondo de 1 color)
            Console.WriteLine(" Añadido headers de color: " + formatting.HeadersColor.Name);
        }
    }
}
