using LibrarySystem.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibrarySystem.utils
{
    public static class LibraryMenuOptions
    {
        public static void PrintBookList(ref Library library)
        {
            if (library.ListOfBooks.Count() == 0)
            {
                Console.WriteLine("Library does not contatin any books");
                return;
            }
            int count = 1;
            foreach (Book book in library.ListOfBooks)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Book " + count);
                Console.WriteLine($"\nTitle:            {book.title}");
                Console.WriteLine($"Author:             {book.author}");
                Console.WriteLine($"Genre:              {book.genre}");
                Console.WriteLine($"Short Description:  {book.description}");
                Console.WriteLine($"ISBN Number:        {book.isbn}");
                Console.WriteLine($"Rating:             {book.rating}");
                Console.WriteLine($"Cost:               {book.cost}");
                Console.WriteLine($"Number of Pages:    {book.numberOfPages}");
                Console.WriteLine("----------------------------");
                count++;
            }

            return;
        }

        //Main switch menu for each option
        public static void Menu(string userInput, ref Library library, ref List<Library> listOfLibraries)
        {
            switch (userInput)
            {
                case "1": //View all books in a library (title and author)
                    ViewAllBooksInSystem(ref library);
                    break;
                case "2": //Edit book in library
                    break;
                case "3": //Add book to library
                    AddBookToLibrary(ref library);
                    break;
                case "4": //Remove book from library
                    break;
                case "5": //Add new library to list
                    CreateNewLibrary(ref listOfLibraries);
                    break;
                case "6": //Edit different library
                    ListAllAvailableLibraries(ref listOfLibraries);
                    break;
                case "7": // Exit
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

        public static bool CheckIfLibrariesExist(ref List<Library> libraries)
        {
            if (libraries.Count() == 0)
                return false; //Return false if no libraries exist in current list
            else
                return true; //Else return true if there is 1 or more libraries in list
        }

        public static Library CreateNewLibrary(ref List<Library> listOfLibraries)
        {
            Console.Write("New Library Name: ");
            string libraryName = Console.ReadLine();
            Library library = new Library(libraryName);
            listOfLibraries.Add(library);
            Console.WriteLine("Creating New Library...");
            Thread.Sleep(4000);
            return library;
        }

        //Create new library based on (1. if library doesnt exist in list, or 2. user prompts to create another library)
        public static string CreateNewLibraryMenu(ref List<Library> libraries)
        {
            //If library doesn't exist in list, ask user for name for new library and return name
            if (!CheckIfLibrariesExist(ref libraries))
            {
                Console.Write("Enter name for new library: ");
                string libraryName = Console.ReadLine();
                return libraryName;
            }

            //If library does exist, and user wants to create new library, prompt user for a name for new library
            string userInput;
            do
            {
                Console.WriteLine("Would you like to create a new library? (Y/N)");
                userInput = Console.ReadLine();
            } while (userInput != "y" || userInput != "Y" || userInput != "n" || userInput != "N");

            if (userInput == "Y" || userInput == "y")
            {
                Console.Write("Name for new library: ");
                string libraryName = Console.ReadLine();
                return libraryName;
            }

            return null;


        }

        //Take in listOfLibraries and run through whole list, printing out title of each library
        public static void ListAllAvailableLibraries(ref List<Library> listOfLibraries)
        {
            Console.Clear();
            Console.WriteLine("Current Available Libraries: ");
            try
            {
                for (int i = 0; i < listOfLibraries.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {listOfLibraries[i].LibraryName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: There are no current libraries. Please create a new library");
            }
            Console.ReadKey();
        }



        public static void ExitFunction()
        {
            //Clear screen and prompt user with exiting statement
            Console.Clear();
            Console.WriteLine("Thanks for editing your library, see ya soon!");
            Console.WriteLine("EXITING...");
            //Sleep so it seems like it shutting down 
            System.Threading.Thread.Sleep(2000);
        }
    }
}
