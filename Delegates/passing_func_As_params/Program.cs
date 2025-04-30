using passing_func_As_params;

namespace passing_func_As_params
{
    class Program
    {
        // declared delegates
        public delegate void PrintDel(int parameter);
        public delegate void PrintTextDel(string text);
        static void Main(string[] args)
        {
            Program p = new Program();
            // calling the PrintHelper function
            p.PrintHelper(100, p.PrintNumber);
            p.PrintHelper(120, p.PrintMoney);

            // return type mentioned
            PrintTextDel p1 = p.PrintText;
            p1("Hello Welcom to c#");

            //PrintTextDel pDel = new PrintTextDel(p.PrintText);
            //pDel("hello albin");

            //PrintTextDel pDel = p.Display();
            //pDel("hello albin");
        }
        /*
         we are passing PrintMoney as a parameter of PrintHelper function,
        so PrintMoney and PrintNumber are ""callback functions"" of PrintHelper function
         */
        public void PrintMoney(int price)
        {
            Console.WriteLine($"Price is {price}");
        }

        public void PrintNumber(int number)
        {
            Console.WriteLine($"Number is {number}");
        }
        /* We want to pass either PrintMOney or PrintNumber as params to below function in c# it is not possbile to do so. then we use delegates for that.*/
        public void PrintHelper(int x, PrintDel del)
        {
            del(x);
        }
        public void PrintText(string msg)
        {
            Console.WriteLine(msg);
        }
        /* returing delegates - any method which match signature of delegate method.- here we returun the PrintText method as return*/
        public PrintTextDel Display()
        {
            return PrintText;
        }
    }
}
