using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Basic
{
    public class Employee
    {
        private string Name;
        private double Salary;
        public string Job;

        public Employee(string name, double salary, string job)
        {
            Name = name;
            Salary = salary;
            Job = job;
        }

        public string GetName() => Name;
        public void SetName(string name) => Name = name;

        public double GetSalary() => Salary;
        public void SetSalary(double salary) => Salary = salary;
    }
}
