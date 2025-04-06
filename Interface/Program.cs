


namespace Interface
{
    class Program
    {

        static void Main(string[] args)
        {
            //create an instance of the customer class
            ICustomer customer1 = new Customer(1, "Albin", "Baby", "albin@gmail.com", "9744004873",
                                                new DateTime(1996, 10, 05), "kreuzstra 12, stuttgart");

            Console.WriteLine($"Full name of customer: {customer1.GetFullName()}");

            /*if try to add a method in Customer classs and the method is not defined in INterface*/
            //customer1.PrintCustomerDetails()://not possible

            Customer customer2 = new Customer(1, "Aline", "Saji", "aline@gmail.com", "15744475550",
                                                new DateTime(2001, 01, 17), "Fuldearstr 1, Ebersburg");

            customer2.PrintCustomerDetails();


        }
    }
}

