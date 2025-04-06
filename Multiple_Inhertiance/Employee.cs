using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inhertiance
{
    public class Employee:IPayable, IReportable
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }

        public void ProcessSalary()
        {
            Console.WriteLine($"Processing slaray for {Name} in {Department} department");
        }

        public void GenerateReport()
        {
            Console.WriteLine($"Generate report for {Name} in {Department} department");
        }

        /* condtion 1 - If the name of the method same for interface what to do ?*/
        void IReportable.Test()
        {
            Console.WriteLine("this  method from IReportable interface");
        }
        void IPayable.Test()
        {
            Console.WriteLine("this  method from IPayable interface");
        }
    }
}
