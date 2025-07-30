internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Method parameters and arguments\n==========+============\n");
        /*
         * Parameters act like Variables in a method
         * They are specified after the method name inside the parenthesis
         * You can add as many parameters as you want by just seperating them with commas
         * example is illustrated below
         */

        static void siblings(string fname)
        {
            Console.WriteLine($"{fname} Awortwe");
        }
        Console.WriteLine("We are five strong brothers and here we are;");
        siblings("Enock");
        siblings("Daniel");
        siblings("Francis");
        siblings("Theophilus");
        siblings("Micheal");

        /*
         * NB: When a `parameter` is passed to a method, it is known as an `Argument`
         * so in the above example; fname is a parameter and [Enock, Daniel, Francis,...] are all arguments.
         */

        Console.WriteLine("\nDefault parameter value\n=============++============");
        /*
         * A parameter with a default value is known as `Optional` Parameter
         * Such a parameter is declared by using the equal sign/assignment operator(=)
         * An example is illustrated below;
         */

        static void countriesVisited(string country = "United Kingdom")
        {
            Console.WriteLine($"I once visited {country} and that trip was a wow");
        }
        countriesVisited("Singapore");
        countriesVisited("La Cote D'Ivoire");
        countriesVisited("Brasil");
        countriesVisited();


        Console.WriteLine("\nMUltiple Parameters\n====================");
        static void studentDetails(string name, int age, int level,string clubteam)
        {
            Console.WriteLine($"I am {name}, and i'm {age} years old. " +
                $"\nI'm currently in level {level}, and i support {clubteam}.\n");
        }
        studentDetails("Kofi Jackson", 20, 200, "Real Madrid");
        studentDetails("Kobina Legit", 19, 100, "Chelsea");
        //NB: The number of parameters should equal the number of arguments passed into the method when calling it

        /*Return values
         * When a method is created with the void keyword, it means the method does not all returning values
         * so the void keyword is replaced with primitive data types
         * like (int or double) if you want to return values.
         * 
         * An example is below
         */

        Console.WriteLine("\nReturn Values\n====================");
        static int calculatefivetimes(int number)
        {
            Console.WriteLine("Enter a number for the multiplication:");
            int num = Convert.ToInt32(Console.ReadLine());
            number = num;
            return 5 * number;
        }
        Console.WriteLine($"Results after multiplication= {calculatefivetimes(10)}");
    }
}