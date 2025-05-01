using LINQ;
using System.Diagnostics;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int> { 22, 30, 29, 30, 21, 15, 32, 30, 60, 40 };
            var evenNumbers = nums.Where(n => n % 2 == 0);
            foreach (var item in evenNumbers)
            {
                Console.WriteLine("Even Numbers: " +item);
            }
        }
    }
}