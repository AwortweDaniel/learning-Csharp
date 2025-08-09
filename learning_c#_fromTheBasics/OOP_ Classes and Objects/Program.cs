internal class Program

{
    class Car
    {
        int door = 2;
        string name = "Vit";
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("C# OOP, classes and Objects\n========================\n");

        /*
         * OOP - is about creating objects that contains both data and methods
         * Procedural Programming is about writing procedures or methods that perform operations on data
         * 
         * OOP has many advantages over proceedural programming; some include: 
         * OOP is faster and easier to execute
         * OOP helps keep the code DRY-- Don't Repeat Yourself 
         * 
         * 
         * Class and Objects are the two main aspects of object oriented programming
         * Class is a blueprint for creating an object
         * An Object is also an instance of a class 
         */


        //Creating a class
        /*Classes and objects are associated with their attributes and methods 
         * 
         * Syntax for creating a class
         * The keyword `class` together with the name of the class
         * An exmaple is illustrated above before the main method
         */

        //Creating an object of the class
        //To create an object, you specify the class name, followed by the object name, and use the keyword new 
        Car myCar = new Car();
       


    //Console.WriteLine("Enter the name of the car");

}
}