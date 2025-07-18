internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("if and else statements");
        /*
         *  Use if to specify a block of code to be executed, if a specified condition is true
            Use else to specify a block of code to be executed, if the same condition is false
            Use else if to specify a new condition to test, if the first condition is false
            Use switch to specify many alternative blocks of code to be executed

            
        Syntax for declaring the if statement
        if (condition) 
        {
            task to perform if condition is met
        }
        eg's done below
         */

        int bignumber = 9;
        int smallnumber = 2;
        if (bignumber > smallnumber)
        {
            Console.WriteLine($"{bignumber} is bigger than {smallnumber}.");
        }


        if (4%2 == 0) {
            Console.WriteLine("4 is divisible by 2");

            }
        else
        {
            Console.WriteLine("It's not divisible by 2");
        }

        Console.WriteLine("Enter the age of the user: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("User must pay Ghs10");
        }
        else if(12 <= age && age <18)
        {
            Console.WriteLine("User must pay Ghs15");
        }
        else
        {

            Console.WriteLine("User must pay Ghs25");
        }


        /*
         * Ternary operator
         * This is also known as the short form of if and else statement
         * the syntax is below
         * variable = (condition)? Trueexpression : FalseExpression
         * 
         * eg below
         */
        string name = "nana".ToUpper();
        string namecheck = (name == "NANA") ? "That's the name" : "The name does not matches";
        Console.WriteLine(namecheck);
    }
}