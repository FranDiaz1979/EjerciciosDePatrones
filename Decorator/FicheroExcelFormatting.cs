using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Decorator
{
    class FicheroExcelFormatting
    {
        public string QuerySQL { get; set; }
        public string Title { get; set; }
        public Color TitleColor { get; set; }
        public Color BackgroundColor { get; set; }
        public Color HeadersColor { get; set; }
        public bool Alternate { get; set; }

        public FicheroExcelFormatting()
        {
            TitleColor = Color.Blue;
            BackgroundColor = Color.LightGreen;
            HeadersColor = Color.Green;
            Alternate = false;
        }
    }
}
