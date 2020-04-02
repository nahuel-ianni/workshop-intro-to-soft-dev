using System;

namespace Recipes
{
    class Program
    {
        /// Concepts covered in this code:
        ///     Console.Write("...") method - Writes text on the console
        ///     Console.ReadLine() method   - Reads user input from the console
        ///     Console.Clear() method      - Clears all the content of the window
        ///     string variable_name = "";  - String variable creation and assignation


        static void Main(string[] args)
        {
            // Declares a set of variables
            string name;
            string consoleGreetings = "Hello, please write your name: ";
            string recipeName = "PIZZA DOUGH recipe, by ";
            string separator = "======================================";

            // Writes the text stored on the 'consoleGreetings' variable into the console application
            Console.Write(consoleGreetings);
            
            // Stores the text the user inputs into the variable 'name', for later use
            name = Console.ReadLine();

            // Clears the content of the console application
            Console.Clear();

            // Writes the content of both the recipeName and name variables on the console application,
            // followed by the separator variable
            Console.WriteLine(recipeName + name);
            Console.WriteLine(separator);

            /// ----------------------------------------------------------------------------
            ///  EXERCISE                                                                    |
            /// ----------------------------------------------------------------------------
            /// Following the recipe from the presentation, create an application that 
            /// displays a table on screen with the list of ingredients, quantity and any 
            /// conditions they might have.
            /// The quantity and conditions should be input by the user.
            /// Example:
            /// Ingredients     |   Comments
            /// Sugar           |   1 teaspoon
            Console.WriteLine();


            // YOUR CODE GOES HERE!


            // Reads a key from the keyboard. Used to pause execution of the application
            Console.ReadKey();
        }
    }
}
