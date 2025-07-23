internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("for loop\n=========================\n");
        /*
         * when you know the number of times you want to loop, you use the for loop instead of the while loop.
         * The syntax for `for loop` is below
         * for (condition1; condition 2; condition 3){executing block code}
         * condition 1- executed once before the block code
         * condition 2- defines th condition for executing the block code
         * condition 3 - executed every time after the block has been executed
         * An example is below;
         * 
        */

        for (int i = 0; i < 5; i += 2)
        {
            Console.WriteLine(i);
        }


        Console.WriteLine("\nForeach loop\n====== ======= ======= =======\n");
        /*Foreach loop
         * is used exclusively to loop through elements in an array
         * syntax is below;
         * foreach (type variableName in arrayName){execute block code}
         * An example is illustrated below;
         */

        int n = 1;
        string[] stuName = { "Enock", "Daniel", "Francis", "Theophilus", "Micheal" };
        while (n < 6) 
        {
            Console.WriteLine("We are five strong brothers\nHere we are...\n"); 
            foreach(string name in stuName)
            {
            
                Console.WriteLine($"{n}. {name}");
                n++;
            }
        }

        
        //So with the example above,
        //a while loop was introduced and it triggers the foreach loop inside the
        //block of codes whilst it condition is true.

    }
}
