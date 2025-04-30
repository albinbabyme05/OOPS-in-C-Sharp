using Delegates;

namespace Delegates
{
    class Program
    {
        // declaring delegates
        delegate int DelegateOperation(int num1, int num2);
        static void Main(string[] args)
        {
            Console.WriteLine($"Result Addition (without delegates): {Add(2,5)}");
            Console.WriteLine($"Result Multiplication(without delegates): {Multiply(2, 5)}");

            DelegateOperation del1 = new DelegateOperation(Add);
            Console.WriteLine($"Result Addition (with delegates):{del1(2,5)}");

            del1 = new DelegateOperation(Multiply);
            Console.WriteLine($"Result Multiplication(with delegates):{del1(2, 5)}");

            Console.WriteLine("==========another way to use delegates=======");

            DelegateOperation del2 = Add;
            int result = del2(2, 5);
            Console.WriteLine(result);

            del2 = Multiply;
            int result2 = del2(2, 5);
            Console.WriteLine(result2);

        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }

}

