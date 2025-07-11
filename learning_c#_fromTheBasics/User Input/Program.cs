internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Accepting user input and making use of it in c#\n" +
            "\n================================================================= \n\n");

        /*
         * To get user input, we use Console.ReadLine();
         * An example is below
         
         */

        Console.WriteLine("Please insert your name as a user: ");
        //Reading user name
        string username = Console.ReadLine();

        Console.WriteLine("The user is, " + username + ".");

        /*
         * NB: ReadLine only return inputs in the string format
         *      and you can convert using the convert built-in function
         *An example is  cited below
         */

        Console.WriteLine("Please enter the age of the oldest kid in the class: ");
        int oldestAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The oldest age in the class is, " + oldestAge + "and he's called "+ username +".");



    }
}