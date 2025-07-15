internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Working with the math class in c#");
        /*
         * The c# Math class has many methods which includes;
         * 1. Math.Max(x,y) - is used to find the highest value of x and y.
         * 2. Math.Min(x,y) - is used to find the lowest or minimum value of x and y.
         * 3. Math.Sqrt(x) - is used to find the square root of x.
         * 4. Math.Abs(x) - is used to find the Absolute (positive) value of x.
         * 5. Math.Round() - is used to round numbers to the nearest whole number
         */

        Console.WriteLine(Math.Max(8, 9));
        Console.WriteLine(Math.Max(3, 12));
        Console.WriteLine(Math.Max(9, 4));
        Console.WriteLine("============");

        Console.WriteLine(Math.Min(6, 5));
        Console.WriteLine(Math.Min(3, 9));
        Console.WriteLine("============");

        Console.WriteLine(Math.Sqrt(9));
        Console.WriteLine(Math.Sqrt(225));
        Console.WriteLine(Math.Sqrt(49));
        Console.WriteLine("============");

        Console.WriteLine(Math.Abs(-9));
        Console.WriteLine(Math.Abs(-19));
        Console.WriteLine(Math.Abs(7));
        Console.WriteLine("============");

        Console.WriteLine(Math.Round(54.4));
        Console.WriteLine(Math.Round( 8.9));
        Console.WriteLine(Math.Round(93.5));
    }
}