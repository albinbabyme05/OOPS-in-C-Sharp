using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.MethodOverloading
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /* Method hase same name but passing different Params -Polymorphism*/
        public void DisplayInformation()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
        public void DisplayInformation(string message)
        {
            Console.WriteLine($"{message}- Name: {Name}, Age: {Age}");
        }
        public void DisplayInformation(string message, int grade)
        {
            Console.WriteLine($"{message}- Name: {Name}, Age: {Age}, Grade: {grade}");
        }
    }
}
