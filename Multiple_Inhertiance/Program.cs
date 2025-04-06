


using Multiple_Inhertiance;

namespace Interface
{
    class Program
    {

        static void Main(string[] args)
        {
            //create an instance of 
            Employee e1 = new Employee("Albin", "Manufacturing");
            e1.ProcessSalary();
            e1.GenerateReport();

            // calling the method with same name for Ipayable and IReportable
            ((IPayable)e1).Test();
            ((IReportable)e1).Test();
           


        }
    }
}

