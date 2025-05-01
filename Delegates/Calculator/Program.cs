using Calculator;

namespace Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator calcAdd = new Calculator();
            MathOperation mat = new MathOperation();
            Calculator calcSub = new Calculator();

            calcAdd.oper += mat.AddNum;
            calcSub.oper += mat.Subtraction;

            int sum = calcAdd.result(8, 4);
            int substraction = calcSub.result(6, 3);
            Console.WriteLine("sum : "+sum);

            Console.WriteLine("substracted value : " + substraction);
        }
    }
}
