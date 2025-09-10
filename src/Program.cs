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
        static void Main(string[] args)
        {
            //Get user option for which command they want to do 
            string userInput = "";
            do
            {

                //Set name of library
                Console.WriteLine("Enter a Name For Your Library");
                Console.Write("Name: ");
                string libraryName = Console.ReadLine();

                //Declare create a library
                Library library = new Library(libraryName);


                Console.Clear();
                

                Prompts.InitialPrompt(libraryName);
                Prompts.InitialUserInput(ref userInput);


                LibraryMenuOptions.Menu(userInput, ref library);
            } while (userInput != "5");

            //Clear screen and prompt user with exiting statement
            Console.Clear();
            Console.WriteLine("Thanks for editing your library, see ya soon!");
            Console.WriteLine("EXITING...");
            //Sleep so it seems like it shutting down 
            System.Threading.Thread.Sleep(2000);

            return;
        }






   
    }


}
