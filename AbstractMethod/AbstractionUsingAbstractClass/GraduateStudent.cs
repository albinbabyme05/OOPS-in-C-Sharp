using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.AbstractionUsingAbstractClass
{
    internal class GraduateStudent: Student
    {
        public string ResearchArea { get; set; }
        

        

        /* Method hase same name but passing different Params -Polymorphism*/
        public override void DisplayInformation()
        {
            Console.WriteLine($"Undergraduate student \n name: {Name}, \n age: {Age}, \n research: {ResearchArea}");
        }
    }
}
