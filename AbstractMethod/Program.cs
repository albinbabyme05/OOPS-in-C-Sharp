using AbstractMethod.AbstractionUsingAbstractClass;


namespace AbstractMethod
{
    class Program
    {

        static void Main(string[] args)
        {
            //create an instance of the class
            Student undergradStud1 = new UnderGraduateStudent { Name = "albin", Age = 28, Major = "cs" };
            Student gradStud1 = new GraduateStudent { Name = "unny", Age = 23, ResearchArea="IT" };

            Console.WriteLine("-----------------------------------------------");

            undergradStud1.DisplayInformation();
            Console.WriteLine("------------------");
            gradStud1.DisplayInformation();
            ResearchArea
        }
    }
}

