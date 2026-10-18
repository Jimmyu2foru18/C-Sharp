using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement
{
    public class EBook : Book
    {
        public string FileFormat { get; }
        public string FileSize { get; }

        public EBook(string title, string author, string isbn, int totalPages, int currentPage) : base(title, author, isbn, totalPages, currentPage)
        {
            Random rnd = new Random();
            string[] formats = { ".pdf", ".epub", ".mobi", ".azw" };
            FileFormat = formats[rnd.Next(formats.Length)];
            FileSize = (rnd.Next(500, 1001)).ToString() + "mb";
        }

        public override string ToString()
        {
            return base.ToString() + $" [EBook, Format: {FileFormat}, Size: {FileSize}]";
        }
    }
}
