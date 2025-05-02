using System.Transactions;
using Temperature_Alter_System;

namespace Temperature_Alter_System
{
    class Program
    {
        public static void Main(string[] args)
        {
            Temperature temp1 = new Temperature();
            Email e = new Email();
            SMS s = new SMS();

            temp1.tempMointorDel += e.SendEmail;
            temp1.tempMointorDel += s.SendSMS;

            Console.WriteLine("Enter the temperature : ");
            float temp = float.Parse(Console.ReadLine());


         
            temp1.CheckTemperature(temp);
        }
    }
}