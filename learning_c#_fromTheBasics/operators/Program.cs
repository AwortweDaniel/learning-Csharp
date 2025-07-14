internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Operators");

        /*
         * '+' operator adds to integers together or calculates the sum of two intergers or doubles
         
         */

        //Console.WriteLine("Enter first number:\n");
        //int firstnumber = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter second number:\n");
        //int secondnumber = Convert.ToInt32(Console.ReadLine());

        //int sum = firstnumber + secondnumber;
        //Console.WriteLine(sum);
        //int sum3 = sum + 100;
        //Console.WriteLine(sum3);


        /*
         so arithmetics operators are used to perform mathematical operations
        Eg; +(addition), -(subtraction), ++(addition by 1), --(subtraction by 1), *(multiplication), %(modulo), /(division)
         */

        int add1 = 10 + 5;
        int sub1 = 12 - 5;
        int mult1 = 4 * 3;
        int div1 = 12 / 4;
        int mod1 = 10 % 6;
        add1 ++;
        sub1--;

        Console.WriteLine(add1 + "\n" + sub1 + "\n" + mult1 + "\n" + div1 + "\n" + mod1);


        /*
         so assignment operators are used to assign values
        Eg; +=(addition assignment), -=(subtraction assignment), *=(multiplication assignment),
        =(assignment), /(division assignment)
        Eg's are below
         */

        double num1 = 234.0;
        Console.WriteLine(num1);
        num1 *= 2;
        Console.WriteLine(num1);
        num1 += 12;
        Console.WriteLine(num1);
        num1 /= 6;
        Console.WriteLine(num1); 
        num1 -= 12;
        Console.WriteLine(num1);

        /*
         so comparison operators are used to compare values
        Eg; ==, <=, >=, <,>,!=
         */

        /*
         so logical operators are used to perform logical operation
        Eg; &&(and), ||(or), !
         */
    }
}
