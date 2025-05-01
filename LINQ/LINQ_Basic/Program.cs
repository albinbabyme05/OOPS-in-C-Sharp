using LINQ_Basic;

namespace LINQ_Basic
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();

            Employee emp1 = new Employee("Albin", 2000, "manager");
            Employee emp2 = new Employee("Unni", 1500, "Assitant Manager");

            employeeList.Add(emp1);
            employeeList.Add(emp2);

            // normal way
            foreach (var employee in employeeList)
            {
                if (employee.Job == "manager")
                {
                    Console.WriteLine($"Name of the Manager : {employee.GetName()}");
                }
            }
            // using Linq
            var managers = from e in employeeList
                           where e.Job == "manager"
                           select e;

            foreach (var employee in managers)
            {
                    Console.WriteLine($"Name of the Manager(LINQ) : {employee.GetName()}");
            }
        }
    }
}