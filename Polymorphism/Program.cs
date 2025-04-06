using Polymorphism.MethodOverloading;

namespace Polymorphism
{
    class Program
    {

        static void Main(string[] args)
        {
            //create an instance of the class
            Student s1 = new Student("Albin", 28);


            // calls the iverloaded methods
            s1.DisplayInformation();
            s1.DisplayInformation("He is an excellent Student of the university");
            s1.DisplayInformation("He is an outsanding this year", 99);

            
        }
    }
}

