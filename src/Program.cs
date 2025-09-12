using LibrarySystem.src;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.utils;


namespace LibrarySystem
{
    class Program
    {
        //Program main entry point
        static void Main()
        {
            //Create list of to hold all libraries in 
            List<Library> listOfLibraries = new List<Library>();

            //Create a new library object
            Library library = new Library();

            //Main user input string
            string userInput = "";

            //Main Program Loop
            do
            {
                //Create initial library to begin
                if (!listOfLibraries.Any())
                    library = LibraryMenuOptions.CreateNewLibrary(ref listOfLibraries);

                Prompts.InitialPrompt(ref library);
                Prompts.InitialUserInput(ref userInput);
                LibraryMenuOptions.Menu(userInput, ref library, ref listOfLibraries);
            } while (userInput != "7");

            LibraryMenuOptions.ExitFunction();

            return;
        }
    }
}
