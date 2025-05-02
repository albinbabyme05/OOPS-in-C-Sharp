using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Alter_System
{
    public class SMS
    {
        public void SendSMS(float value)
        {
            Console.WriteLine("Sending sms...");

            Thread.Sleep(2000);
            Console.WriteLine("sms has sent.");
        }
    }
}
