using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.utils
{
    public static class Prompts
    {
        
        //Inital prompt at start of program runtime
        public static void InitialPrompt(string libraryName)
        {
            Console.WriteLine($"Welcome to the {libraryName} library!");
            Console.WriteLine("\n\nPlease select one of the corresponding numbers");
            Console.WriteLine("1. View all the books \n2. Edit a book \n3. Add a book \n4. Remove a book \n5. Exit");

            return;
        }

        //Get user input for which command they would like to execute
        public static string InitialUserInput(ref string userInput)
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
