internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n Type Casting in C#\n==================================\n");

        /*
         * Typecasting in c# is of two types 
         * namely;
         * Implicit TypeCasting and Explicit TypeCasting
         * 
         * Implicit TypeCasting is converting a smaller type to a longer type size.
         * 
         * Explicit is also converting a larger type to a smaller type size.
         * eg; from double to float to long to int
         
         */

        Console.WriteLine("Implicit TypeCasting");

        int myNum = 9;

        //converting the integer to double.
        double myDouble = myNum;

        //converting integer to float
        
        float myFloat = myNum;

        Console.WriteLine(myNum);
        Console.WriteLine(myDouble);
        Console.WriteLine(myFloat);


        Console.WriteLine("\n\nExplicit TypeCasting");

        double newDouble = 9.85;

        //coverting to int
        int newInt = (int)newDouble;

        Console.WriteLine(newDouble);
        Console.WriteLine(newInt);


        /*
         * Manual conversion using inbuilt functions
         * like; Convert.ToString(), convert.toInt() and more
         */
        Console.WriteLine("\n\nUsing InBuilt functions");

        bool IsGuy = true;
        int age = 12;
        double dec = 123.3;

        Console.WriteLine(Convert.ToString(IsGuy));
        Console.WriteLine(Convert.ToDecimal(age));
        Console.WriteLine(Convert.ToInt64(dec));

    }
}