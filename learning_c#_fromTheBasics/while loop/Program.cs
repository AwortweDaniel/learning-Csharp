internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("While loop");
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

        /*
         * Another variant of the while loop is the do while loop
         * for this as the name suggests, a block of codes is executed first,
         * before checking if the condition is true, and then repeat until the condition changes to False
         * 
         * Syntax for do while loop is below;
         * do
         * {
         *     execute task
         * }while(condition);
         * 
         * An example is below
         */

        int j = 0;
        do
        {
            Console.WriteLine(j);
            j++;
        } while (j < 10);
    }
}