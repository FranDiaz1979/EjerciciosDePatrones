namespace Decorator
{
    using System;
    using System.Collections.Generic;
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
        public void GenerarFichero(string querySQL, string title)
        {
            var data = Utilidades.RequestDataBase(querySQL);

            CreateExcelFile();
            FillExcelFile(data);
            FormatExcelFile(title);
        }

        private void CreateExcelFile()
        {
            // file = File.Create(Path + FileName + "." + Extension);
        }

        private void FillExcelFile(Object data)
        {
        }

        private void FormatExcelFile(string title)
        {
            // Formatea la cabecera de la pagina (fila 1 más ancha, con 1 color, con titulo en letra más grande, etc.)
            // Pone el color de fondo elegido desde la fila 2 en adelante
            // A veces queremos que el fichero alterne linea en color con linea en blanco
            // Formatea los titulos de los campos (fila 2 en negrita con fondo de 1 color)
            // etc. (he borrado 4 línea más que hace mi libreria de excels)
        }
    }
}
