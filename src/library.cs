using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem.src
{
    struct Library
    {
        //Library Name
        string LibraryName { get; set; }
        
        //List of all books in the library
        List<Book> ListOfBooks { get; set; }




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

        public void PrintBookList()
        {
            foreach (Book book in this.ListOfBooks)
            {
                Console.WriteLine($"\n\nTitle:          {book.title}");
                Console.WriteLine($"Author:             {book.author}");
                Console.WriteLine($"Genre:              {book.genre}");
                Console.WriteLine($"Short Description:  {book.description}");
                Console.WriteLine($"ISBN Number:        {book.isbn}");
                Console.WriteLine($"Rating:             {book.rating}");
                Console.WriteLine($"Cost:               {book.cost}");
                Console.WriteLine($"Number of Pages:    {book.numberOfPages}");
            }
        }
    }
}
