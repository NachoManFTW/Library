using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibrarySystem
{
    class Program
    {
        //Program main entry point
        static void Main()
        {
            //Get user option for which command they want to do 
            string userInput = "";

            InitialPrompt();
            InitialUserInput(ref userInput);

            

        }



        //Main switch menu for each option
        void Menu(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;
            }
        }


        void ViewAllBooksInSystem()
        {

        }

        //Inital prompt at start of program runtime
        static void InitialPrompt()
        {
            Console.WriteLine("Library");
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
    }


}
