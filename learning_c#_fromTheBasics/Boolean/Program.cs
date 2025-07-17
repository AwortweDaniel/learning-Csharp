internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Booleans-True or False");
        /*
         * bool is a data type that can values true or false
         * Declaring boolean variables, the syntax is `bool` keyword + variable name
         * Examples are below;
         */

        bool isABoy = true;
        bool isMyFriend = false;
        bool isGood = false;
        Console.WriteLine(isABoy);
        Console.WriteLine(isGood);
        Console.WriteLine("Enter true or false");
        string newk = Console.ReadLine();
        Console.WriteLine(newk);

        Console.WriteLine(newk == Convert.ToString(isGood));


    }
}