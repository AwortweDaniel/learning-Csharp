using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] Args)
    {
        Console.WriteLine("Break & Continue\n====== - ======\nBreak\n===_===");

        /*Break 
         *-Is used to the jump out of a switch statement
         *-Is used to also jump out of a loop condition
         *
         *A example is illustrate below;
         */

        for (int i =0; i < 10; i += 2)
        {
            if (i == 8)
            {
                break;
            }
            Console.WriteLine(i);
        }

        /*Continue
         * - Is used to break one iteration in a loop if a specified condition occurs,
         * and continues with the next iteration in the loop
         * 
         * An example is below;
         * 
         */
        Console.WriteLine("\nContinue\n============");
        for (int j = 0; j < 5; j++)
        {
            if (j == 3)
            {
                continue;
            }
            Console.WriteLine(j);
        }
        //The example above skips when j=4

        Console.WriteLine("\nBreak and continue in a while loop\n==============================");

        int n = 0;
        while (n < 20)
        {
            if (n == 12)
            {
                n += 2;
                continue;
            }
            Console.WriteLine(n);
            n += 2;

        }

        Console.WriteLine("\nBreak in a while loop\n==============================");
        int k = 0;
        while (k < 30)
        {
            Console.WriteLine(k);
            k += 3;

            if (k * 2 == 24)
            {
                break;
            }

            
        }

    }
}