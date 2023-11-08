using System;
using System.Windows.Forms;

namespace XD_2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustan", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 100);
            Car Volvo = new Car("XC-96");
            Car BMW = new Car { name = "da", color = "red", year = 1000, maxSpeed = 50 };

            /*
            Car1 Ford = new Car1(); 
            Car1 Opel = new Car1();
            Ford.name = "mustang";
            Ford.year = 2021;
            Ford.color = "white";
            Ford.maxSpeed = 100;
            Opel.name = "astra";
            Opel.year = 2020;
            Opel.color = "blue";
            Opel.maxSpeed = 120;
            */
            Console.WriteLine(Ford.name);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Ford.year);
            Ford.fullThrotle();
            Console.WriteLine(Opel.name);
            Console.WriteLine(Opel.color);
            Console.WriteLine(Opel.year);
            Console.WriteLine(Opel.maxSpeed);
            Opel.fullThrotle();
            Console.ReadKey();
        }
    }
}
