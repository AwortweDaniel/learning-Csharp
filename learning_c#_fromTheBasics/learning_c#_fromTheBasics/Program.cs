
using System;
using static learning_c__fromTheBasics.tutorials_classes.student_class;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Student Biggie = new Student();
            Console.WriteLine(Biggie.Name);
        }
    }

}
//{
//    class Car
//    {
//        string color = "red";
//        static void Main(string[] args)
//        {
//            Car myObj1 = new Car();
//            Car myObj2 = new Car();
//            Console.WriteLine(myObj1.color);
//            Console.WriteLine(myObj2.color);
//        }

//    }
//}