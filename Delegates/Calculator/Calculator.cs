using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public delegate int OperationHandler(int m, int n);
    public class Calculator
    {   
        public OperationHandler oper;
        public int result(int x, int y)
        {

            return oper(x, y);
        }
    }
}
