internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Switch Statement\n===================\n");
        /*
         * switch statement is used to select one of many code blocks to be executed.
         * 
         * The syntax is below;
            switch(expression) 
            {
              case x:
                // code block
                break;
              case y:
                // code block
                break;
              default:
                // code block
                break;
            }
         * 
            
            This is how it works:

            The switch expression is evaluated once
            The value of the expression is compared with the values of each case
            If there is a match, the associated block of code is executed
            The break and default keywords will be described later

            example to calculate the weekday name;
            
         */

        int day = 4;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;

            case 2:
                Console.WriteLine("Tuesday");
                break;

            case 3:
                Console.WriteLine("Wednesday");
                break;

            case 4:
                Console.WriteLine("Thursday");
                break;

            case 5:
                Console.WriteLine("Friday");
                break;

            case 6:
                Console.WriteLine("Saturday");
                break;

            case 7:
                Console.WriteLine("Sunday");
                break;

        }

        /*
         * The `break` keyword 
         * When c# code reaches the break keyword, it breaks out of the switch block
         * And this will stop more code from executing and case testing inside the block
         * when the match is found, the job is done, it's time for break and no more case testing
         * 
         * So a break will reduce execution time, because it ignores the other cases when the match is found.
         */

        /*
         * The `default` keyword
         * The default keyword is optional and specifies some codes to run when the no case is matched
         * example is below;
         */
        int age = 2;
        switch (age)
        {
            case 6:
                Console.WriteLine("You're still a kid");
                break;

            case 12:
                Console.WriteLine("You're still growing");
                break;

            case 18:
                Console.WriteLine("You're official opened to adult opportunities");
                break;

            default:
                Console.WriteLine("You're a human being and you will definitely grow up");
                break;
        }
    }
}