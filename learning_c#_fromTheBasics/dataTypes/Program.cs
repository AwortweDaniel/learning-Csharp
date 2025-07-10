internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("DataTypes\n=================================\n");

        /*
         * The dataTypes in c#  include; 
         * int for numbers
         * double for decimals
         * string for sequence of characters
         * char for a single character
         * bool for true or false
         */

        int age = 12;
        double shoeSize = 39.05;
        string stuName = "Geniel";
        char det = 'a';
        bool isGood = true;

        Console.WriteLine(stuName + ", " + det + " good lady, is " + age + "years old.");
    }
}