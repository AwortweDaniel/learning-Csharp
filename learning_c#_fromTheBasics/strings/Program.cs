internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Working with strings");
        /*
         * Strings are used for storing texts
         * A String is a variable that contains a collection of characters surrounded by double quotes
         * eg's
         */
        string greeting = "hello";
        Console.WriteLine(greeting);

        //To find the length of a string, we use ".length" property of the string
        //eg's

        //printing the length of the greeting variable
        Console.WriteLine(greeting.Length);

        /*
         * Other methods include;
         * ToUpper() and ToLower() methods which converts the string to Uppercase or Lowercase
         * eg's
         */

        Console.WriteLine("Enter first name in lowercase:");
        string highname1 = Console.ReadLine();
        Console.WriteLine(highname1);
        //converting to uppercase
        Console.WriteLine(highname1.ToUpper());


        Console.WriteLine("Enter second name in uppercase or camelcase:");
        string lowname2 = Console.ReadLine();
        Console.WriteLine(lowname2);
        //converting to lowercase
        Console.WriteLine(lowname2.ToLower());

        /*
         * String concatenation includes using the + operator between strings to combine them.
         * you can also use string.Concat() method to concatenate two strings.
         * eg's are below
         */
        //concatenating the highname and lowname
        Console.WriteLine(highname1.ToUpper() + lowname2.ToLower());

        Console.WriteLine(string.Concat(highname1, lowname2));

        //String interpolation is another option for string concatenation
        // We use ${} to do the string interpolation
        string fullname = $"My full name is {highname1.ToUpper()},{lowname2}";
        Console.WriteLine(fullname);

    }
}