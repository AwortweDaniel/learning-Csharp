internal class Program
{
    public static int plusMethod(int x, int y)
    {
        return x + y;
    }
    public static double plusMethod(double x, double y)
    {
        return x + y;
    }

    

    private static void Main(string[] args)
    {
        Console.WriteLine("Method Overloading");

        /*Method Overloading
         * declaring multiple methods with the same name but different parameters
         * Examples include;
         * int myMethod(int x)
         * double myMethod(double y)
         * float myMethod(float z)
         */

        Console.WriteLine("\nOverloading the plusMethod below\n============================");

        int myintAnswer = plusMethod(2, 4);
        double mydoubleAnswer = plusMethod(2.4, 5.3);

        Console.WriteLine($"The integer calculated addition is {myintAnswer}");
        Console.WriteLine($"The double calculated addition is {mydoubleAnswer}");


        //The methods were declared outside and above the main method
    }
        
        
       
    }
