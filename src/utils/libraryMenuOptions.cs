using LibrarySystem.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.utils
{
    public static class LibraryMenuOptions
    {
        public static void PrintBookList(ref Library library)
        {
            int count = 1;
            foreach (Book book in library.ListOfBooks)
            {
                Console.WriteLine("Book " + count);
                Console.WriteLine($"\n\nTitle:          {book.title}");
                Console.WriteLine($"Author:             {book.author}");
                Console.WriteLine($"Genre:              {book.genre}");
                Console.WriteLine($"Short Description:  {book.description}");
                Console.WriteLine($"ISBN Number:        {book.isbn}");
                Console.WriteLine($"Rating:             {book.rating}");
                Console.WriteLine($"Cost:               {book.cost}");
                Console.WriteLine($"Number of Pages:    {book.numberOfPages}");
                count++;
            }

            return;
        }

        //Main switch menu for each option
        public static void Menu(string userInput, ref Library library)
        {
            switch (userInput)
            {
                case "1": //View all books in library (title and author)
                    ViewAllBooksInSystem(ref library);
                    break;
                case "2": //Edit book in library
                    break;
                case "3": //Add book to library
                    AddBookToLibrary(ref library);
                    break;
                case "4": //Remove book from library
                    break;
                case "5": // Exit
                    break;
                default:
                    break;
            }
        }

        //View all books currently in the library, get list from library struct and iterate over each book in the list printing title and author
        public static void ViewAllBooksInSystem(ref Library library)
        {
            LibraryMenuOptions.PrintBookList(ref library);
        }

        //Create a new book with all variable filled in
        public static void AddBookToLibrary(ref Library library)
        {
            //Get title
            Console.Write("\nTitle: ");
            string title = Console.ReadLine();

            //Get author
            Console.Write("\nAuthor: ");
            string author = Console.ReadLine();

            //Get genre
            Console.Write("\nGenre: ");
            string genre = Console.ReadLine();

            //Get short description of book 
            Console.Write("\nShort Description: ");
            string description = Console.ReadLine();

            //Get isbn number of book
            Console.Write("\nBook ISBN Number: ");
            string isbn = Console.ReadLine();

            //Get average rating of book
            Console.Write("\nAverage Rating (1-10): ");
            string rating = Console.ReadLine();

            //Get cost of book in USD, loop until double is added
            decimal cost;
            do
            {
                Console.Write("\nCost USD: ");

            } while (!decimal.TryParse(Console.ReadLine(), out cost));

            //Get page count, int, no half pages or less than zero pages
            uint pagesCount;
            do
            {
                Console.Write("\nNumber of Pages: ");

            } while (!uint.TryParse(Console.ReadLine(), out pagesCount));

            //Create new book object with values
            Book newBook = new Book(title, author, genre, description, isbn, rating, cost, pagesCount);

            //Push new book to library list
            library.PushBookToList(ref newBook);

            return;
        }
    }
}
