using Multicast_Delegates;

namespace Multicast_Delegates
{
    class Program
    {
        // method1
        public delegate void Del();//declaring void delicate 

        // method2
        public delegate int DelNumber();

        // method3
        public delegate void DelNum(out int x);

        static void Main(string[] args)
        {
            Program p = new Program();
            Del d1 = p.Method1;
            Del d2 = p.Method2;
            Del d3 = p.Method3;

            //method1
            /* using differenr instance of same delegate using '+' operator */
            Del d4 = d1 + d2 + d3 - d1; //-d1 will removed 

            d4();

            Console.WriteLine("===========case1===========");
            /*
             * Multicast delegate invokes the method in the same order in which they are added. 
             * It uses Fírst in first out approach
             */
            Del d5 = d1 + d3 + d2;

            d5();

            Console.WriteLine("===========case2===========");

            /*using single instance and point to different functions using '+='*/
            Del del = p.Method1;
            del += p.Method2; // referencing 'del'  to method two and three
            del += p.Method3;

            del -= p.Method2; // removing the referencing

            del();

            Console.WriteLine("============Case3==========");

            //method2
            /*
             * if delegate has a return type other than void, and it is multicast delegate,
             * only the value of the last invoked method will be returned
             */

            DelNumber delnum = p.MethodOne;
            int result  = delnum();
            Console.WriteLine(result);

            Console.WriteLine("============Case4==========");
            DelNumber delnumReturn = p.MethodOne;
            delnumReturn += p.MethodThree;
            delnumReturn += p.MethodTwo;

            int final = delnumReturn();
            Console.WriteLine(final); // returnin lastly retrun value of that method
            Console.WriteLine("============Case5==========");

            //method 3

            /*
             * if the delegate has an output parameter,
             * the value of the output parameter will be the value assigned to it by the last method
             */
            DelNum delnumOutput = p.One;
            delnumOutput += p.Three;
            delnumOutput += p.Two;

            int finalOut;
            delnumOutput(out finalOut);
            Console.WriteLine(finalOut);
        }

        //method1
        public void Method1() { Console.WriteLine("Method one called"); }
        public void Method2() { Console.WriteLine("Method two called"); }
        public void Method3() { Console.WriteLine("Method three called"); }

        //method2
        public int MethodOne() => 1;
        public int MethodTwo() => 2;
        public int MethodThree() => 3;

        //method3
        public void One(out int num) { num = 1; }
        public void Two(out int num) { num = 2; }
        public void Three(out int num) { num = 3; }
    }
}
