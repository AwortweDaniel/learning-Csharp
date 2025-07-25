using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Arrays in c#");

        /*Arrrays are used to store multiple values in a single variable,
         * instead of declaring a variable for each value
         * 
         * The syntax is below;
         * variableType[] variableName = {comma-seperated values};
         * 
         * Arrays can ne declared without values and later values will be added
         * as in;
         * varianbleType[] variableName ;
         * ~ examples is below;
         * 
         */

        string[] sblNames = { "Enock", "Daniel", "Francis", "Theophilus", "Micheal" };
        Console.WriteLine("\n\nSibling names array\n==================\n");
        foreach (string name in sblNames)
        {
            Console.WriteLine(name);
        }
        

        //declaring array without values
        Console.WriteLine("\nDeclaring an array without values\n");
        string[] chelseaCaptains;

        //Adding values to the declared array
        Console.WriteLine("\nAdding values to the declared array.\n");
        chelseaCaptains = ["Reece James", "Enzo Fernandez", "Moises Caicedo", "Levi Colwil"];
        Console.WriteLine("\n\nChelsea's captains in order are:\n==================\n");
        foreach (string captain in chelseaCaptains)
        {
            Console.WriteLine(captain);

        }

        //Accesing a value in an array variable, we use the index of the variable
        //An example is below- getting the first captain

        Console.WriteLine($"\nThe first or main chelsea captain of this current squad is {chelseaCaptains[0]}\n\n");


        //Changing a value in the array variable;
        chelseaCaptains[3] = "Cole Palmer";
        Console.WriteLine("After the 4th captain is changed.\n");
        foreach(string cap in chelseaCaptains)
        {
            Console.WriteLine(cap);
        }


        //Array length- To find how many element an array has
        //arrayName.length property is used;
        //An example is below, finding the length of the siblings array

        Console.WriteLine($"\nThe siblings array has {sblNames.Length} elements\n");

        //looping through the siblings array,
        //and specifying the number of times the loop should run using the length property.
        for(int i = 0; i<sblNames.Length; i++)
        {
            Console.WriteLine(sblNames[i]);
        }

        //Sorting Arrays in aphabetical or ascending order
        //Syntax- Array.sort(arrayName)
        //Example is below;

        int[] marks = { 12, 75, 82, 34, 54, 73, 23, 034, 45 };
        //before sorting
        Console.WriteLine("\nBefore sorting");
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }

        //after sorting
        Array.Sort(marks);
        Console.WriteLine("\nAfter sorting");
        foreach (int mark in marks)
        {
            Console.WriteLine(mark);
        }

        //System.Linq namespace- other useful array methods like the max, min, sum and more
        //examples are below;

        Console.WriteLine($"The highest mark is: {marks.Max()}.");
        Console.WriteLine($"The Lowest mark is: {marks.Min()}.");
        Console.WriteLine($"All the marks sum up to: {marks.Sum()}.");
        Console.WriteLine("\n\n");

        //Final touches on Arrays.

        // Create an array of four elements, and add values later
        string[] teams = new string[4];

        // Create an array of four elements and add values right away 
        string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

        // Create an array of four elements without specifying the size 
        string[] carbrands = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

        // Create an array of four elements, omitting the new keyword, and without specifying the size
        string[] carmodels = { "Volvo", "BMW", "Ford", "Mazda" };

        /*
         * It is up to you which option you choose. 
         * In our tutorial, we will often use the last option, as it is faster and easier to read.

          However, you should note that if you declare an array and initialize it later,
          you have to use the new keyword
         */

        // Declare an array
        string[] countries;

        // Add values, using new
        countries = new string[] { "Ghana", "India", "England"};
    }

}