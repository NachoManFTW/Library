using LibrarySystem.src;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem
{
    class Program
    {
        //Program main entry point
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Name For Your Library");
            string libraryName = Console.ReadLine();


            //Declare create a library
            Library library = new Library(libraryName);


            //Get user option for which command they want to do 
            string userInput = "";

            InitialPrompt(libraryName);
            InitialUserInput(ref userInput);


            Menu(userInput, ref library);

            library.PrintBookList();

        }



        //Main switch menu for each option
        static void Menu(string userInput, ref Library library)
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
        static void ViewAllBooksInSystem(ref Library library)
        {
        }

        //Create a new book with all variable filled in
        static void AddBookToLibrary(ref Library library)
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
        }

        

        //Inital prompt at start of program runtime
        static void InitialPrompt(string libraryName)
        {
            Console.WriteLine($"Welcome to the {libraryName} library!");
            Console.WriteLine("\n\nPlease select one of the corresponding numbers");
            Console.WriteLine("1. View all the books \n2. Edit a book \n3. Add a book \n4. Remove a book \n5. Exit");
        }

        //Get user input for which command they would like to execute
        static string InitialUserInput(ref string userInput)
        {
            //Loop until one of the options are selected
            do
            {
                Console.Write("Selection: ");
                userInput = Console.ReadLine();

                //If one of the options is selected, break from loop, otherwise prompt user to enter a number between 1 and 5
                if (userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4" || userInput == "5")
                    break;
                else
                    Console.WriteLine("ERROR: Select 1-5");
            } while (true);
            return userInput;
        }



        /*
        public void LoadJson()
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Book> items = JsonConvert.DeserializeObject<List<Book>>(json);
            }
        }
        */
    }


}
