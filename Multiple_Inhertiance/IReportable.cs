using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inhertiance
{
    public interface IReportable
    {
        void GenerateReport();

        /* condtion 1 - If the name of the method same for interface what to do ?*/
        void Test();
    }
}
