using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.Speed = 3;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;

            Fan fan2 = new Fan();
            fan2.Speed = 2;
            fan2.Radius = 5;
            fan2.Color = "blue";
            fan2.On = false;

            Console.WriteLine("Fan 1: " + fan1.ToString());
            Console.WriteLine("Fan 2: " + fan2.ToString());
            Console.ReadKey();
        }
    }
}
