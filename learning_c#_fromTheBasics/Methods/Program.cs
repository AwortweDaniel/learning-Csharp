internal class Program
{
    private static void Main(string[] Args)
    {
        Console.WriteLine("Methods in c#\n");

        /*Methods
         * Method is a block of code that runs when it is called
         * Methods are known as functions, and they perform a defined task
         * Reason for methods- to declare code once and reuse them many times
         * 
         * Creating Methods in C#
         */

        Console.WriteLine("Creating Methods in c#:\n");
        //Creating a method named  MyGreeting
        static void MyGreeting()
        {
            Console.WriteLine("Greetings Your Highness\nHail the generous king.");
        }
        /*Insights about the syntax in method creation
         * static- means the method belongs to the program class and not an object of the program class.
         * void- means the method does not have a return value
         * MyGreeting() is the name of the method
         */

        //Calling a created method
        Console.WriteLine("\nCalling the created method, MyGreeting() in the main method\n");
        MyGreeting(); //since i'm already in the main method,
                      //else i should have created the main method and call the created method in it.



    }
}
