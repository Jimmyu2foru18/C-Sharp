using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement
{
    public class AudioBook : Book
    {
        public string Narrator { get; }
        public string Duration { get; }

        public AudioBook(string title, string author, string isbn, int totalPages, int currentPage) : base(title, author, isbn, totalPages, currentPage)
        {
            Random rnd = new Random();
            string[] narrators = { "Jimmy", "Adebayo", "Brandon", "Joel", "Jugraj", "Miriam", "Mohammad", "Adan", "Steven", "Alexis" };
            Narrator = narrators[rnd.Next(narrators.Length)];
            TimeSpan time = TimeSpan.FromMinutes(rnd.Next(1, 1441));
            Duration = time.ToString(@"hh\:mm");
        }

        public override string ToString()
        {
            return base.ToString() + $" [Audiobook, Narrator: {Narrator}, Duration: {Duration}]";
        }
    }
}
