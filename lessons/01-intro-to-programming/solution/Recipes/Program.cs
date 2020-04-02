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

            // Notify the user what will be needed out of him/her
            Console.WriteLine(
                $"{name}, let's go through the ingredients needed to prepare your pizza dough.\n" +
                $"Don't forget to specify if the ingredient has any special condition!");
            
            // Ask the user for the ingredients, making sure he/she knows what is required to do
            Console.Write("\nHow much yeast do you need? ");
            string yeast = Console.ReadLine();

            Console.Write("\nHow much sugar do you need? ");
            string sugar = Console.ReadLine();

            Console.Write("\nHow much water do you need? ");
            string water = Console.ReadLine();

            Console.Write("\nHow much oil do you need? ");
            string oil = Console.ReadLine();

            Console.Write("\nHow much salt do you need? ");
            string salt = Console.ReadLine();

            Console.Write("\nHow much flour do you need? ");
            string flour = Console.ReadLine();

            Console.Clear();

            // Show the user how the ingredient table looks at the end
            Console.WriteLine(
                $"{recipeName}{name}\n\n" +
                $"Ingredients table\n" +
                $"|     Ingredient      |       Comments             |\n" +
                $"| =================== | ========================== |\n" +
                $"|     Yeast           |       {yeast}               \n" +
                $"|     Sugar           |       {sugar}               \n" +
                $"|     Water           |       {water}               \n" +
                $"|     Oil             |       {oil}                 \n" +
                $"|     Salt            |       {salt}                \n" +
                $"|     Flour           |       {flour}               \n" +
                $"  =================== | ==========================  \n");

            // Reads a key from the keyboard. Used to pause execution of the application
            Console.ReadKey();
        }
    }
}
