internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Variables Declaration\n===============================");

        /*Rules for variable declaration
         *  The general rules for constructing names for variables (unique identifiers) are:
            Names can contain letters, digits and the underscore character (_)
            Names must begin with a letter
            Names should start with a lowercase letter and it cannot contain whitespace
            Names are case sensitive ("myVar" and "myvar" are different variables)
            Reserved words (like C# keywords, such as int or double) cannot be used as names
         * 
         */

        /* Syntax for declaring variables in c# is
         * dataType variableName = value;
            */
        int age = 12;
        string name = "John";

        Console.WriteLine("\n"+name +" is "+age + " years old." );

        /* You can also declare a variable without assigning values to it, and later assign values to it.
         * An example is illustrated below
         */
        int score;
        double cwa;
        string studentName;

        score = 89;
        cwa = 98.23;
        studentName = "Nana";

        Console.WriteLine(studentName + " scored " + score + " in the course, and his cwa increased to " + cwa);

        Console.WriteLine("\n\nDeclaring constants\n=====================");
        /* When constants are declared, their values initially assigned to them can not be changed
         * In declaring constants, this syntax is used;
         * const dataType constantName = value;
         * 
         * Examples are illustrated below
         */
        const int newAge = 9;
        Console.WriteLine("The guy's new age is " + newAge +".");

        Console.WriteLine("\n\nDeclaring multi variables on the same line\n=====================");
        /* With this, the variables are declared in a comma seperated form
         * In declaring these variables, for example a,b,and c on the same line, this syntax is used;
         * dataType variableName= value, variableName= value, variableName= value;
         * 
         * Examples are illustrated below
         */
        int a = 9, b= 6, c= 3;
        Console.WriteLine(a + b + c);


    }
}