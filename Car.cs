using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XD_2023
{
    public class Car
    {
       
        public string color;
        public string name;
        public int maxSpeed;
        public int year;
        public Car(string modelName, string colorName, int yearValue, int maxSpeedValue )
        {
            name = modelName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }
        public void fullThrotle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }
    }
}
