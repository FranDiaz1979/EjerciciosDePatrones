namespace Decorator
{
    using System;
    using System.IO;

    class UtilidadesExcel
    {
        public void GenerarFichero(FileStream file, string querySQL, string title)
        {
            var data = RequestDataBase(querySQL);
            CreateExcelFile(file);
            FillExcelFile(file, data);
            FormatExcelFile(file, title);
        }

        private Object RequestDataBase(string consultaSQL)
        {
            return null;
        }

        private void CreateExcelFile(FileStream file)
        {
        }

        private void FillExcelFile(FileStream file, Object data)
        {
        }

        private void FormatExcelFile(FileStream file, string title)
        {
            // Formatea la cabecera de la pagina (fila 1 más ancha, con 1 color, con titulo en letra más grande, etc.)
            // Formatea los titulos de los campos (fila 2 en negrita con fondo de 1 color)
            // etc... 
        }
    }
}
