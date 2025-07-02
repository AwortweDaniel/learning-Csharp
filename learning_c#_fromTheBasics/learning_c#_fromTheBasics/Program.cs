
using System;
using static learning_c__fromTheBasics.tutorials_classes.student_class;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student Biggie = new Student();
            Console.WriteLine(Biggie.Name);
        }
    }
}