﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(" loops - for and while");
        /*
         * Loops are codes or can execute a block of codes so far as a condition is met
         * Loops are handy because they save time, reduce more error and makes code more readable
         * 
         * While loop
         * The while loop loops through a block of codes so far as a condition is true
         * The Syntax is below;
         * while(condition)
         * {
         *      execute this task
         * }
         * 
         * examples are below;
         
         */

        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }


    }
}