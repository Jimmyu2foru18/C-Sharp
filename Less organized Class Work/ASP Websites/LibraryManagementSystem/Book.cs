using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string ISBN { get; }
        public int TotalPages { get; }
        public int CurrentPage { get; }

        public Book(string title, string author, string isbn, int totalPages, int currentPage)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            TotalPages = totalPages;
            CurrentPage = currentPage;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}, Current Page: {CurrentPage}/{TotalPages}";
        }
    }
}
