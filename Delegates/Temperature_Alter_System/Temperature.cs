using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Alter_System
{
    public delegate void TemperatureHandler(float tempValue);
    public class Temperature
    {
        public TemperatureHandler tempMointorDel;
        
        public void CheckTemperature(float temp)
        {
            if (temp > 32)
            {
                Console.WriteLine("checking temperature...");
                Thread.Sleep(3000);
                Console.WriteLine($"Temperature {temp} is High");

                tempMointorDel(temp);
            }
            else
            {
                Console.WriteLine($"Temperature {temp} is low");
            }
        }
    }
}
