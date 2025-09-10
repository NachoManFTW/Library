using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem.src
{
    public struct Library
    {
        //Library Name
        string LibraryName { get; set; }
        
        //List of all books in the library
        public List<Book> ListOfBooks { get; set; }




        //Set name of library and create a new list in the library
        public Library(string libraryName)
        {
            this.LibraryName = libraryName;
            this.ListOfBooks = new List<Book>();
        }




        //Push new book to back of list anytime this method is called
        public void PushBookToList(ref Book book)
        {
            this.ListOfBooks.Add(book);
        }


    }
}
