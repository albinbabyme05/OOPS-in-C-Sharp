using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod.AbstractionUsingAbstractClass
{
    class UnderGraduateStudent : Student
    {

        public string Major { get; set; }

        public override void DisplayInformation()
        {
            Console.WriteLine($"Undergraduate student \n name: {Name}, \n age: {Age}, \n major: {Major}");
        }

    }
}
