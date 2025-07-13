internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Operators");

        /*
         * '+' operator adds to integers together or calculates the sum of two intergers or doubles
         
         */

        Console.WriteLine("Enter first number:\n");
        int firstnumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:\n");
        int secondnumber = Convert.ToInt32(Console.ReadLine());

        int sum = firstnumber + secondnumber;
        Console.WriteLine(sum);


    }
}