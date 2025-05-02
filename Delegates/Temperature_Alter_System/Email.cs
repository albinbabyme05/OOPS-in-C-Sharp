using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Alter_System
{
    public class Email
    {
        public void SendEmail(float value)
        {
            Console.WriteLine("Sending email...");

            Thread.Sleep(2000);
            Console.WriteLine("email has sent.");
        }

    }
}
