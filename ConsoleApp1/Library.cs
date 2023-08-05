using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08
{
    internal class Library: ILibrary
    {
        private Dictionary<string, Book> Storage;

        public Library() 
        {
            Book book1 = new Book("To Kill a MockingBird","Some Weirdo");
            Book book2 = new Book("War and Peace", "Some war dude, or peace dude, or both.");
            Book book3 = new Book("")
        }

    }
}
