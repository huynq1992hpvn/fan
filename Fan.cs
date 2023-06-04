using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fan
{
    public class Fan
    {
        private const int slow = 1;
        private const int medium = 2;
        private const int fast = 3;
        private int speed;
        private bool on;
        private double radius;       
        private string color;

        public static int Slow => slow;

        public static int Medium => medium;

        public static int Fast => fast;

        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }
        public Fan()
        {
            speed = slow;
            on = false;
            radius = 5;
            color = "blue";
        }
        public override string ToString()
        {
            if (on)
            {
                return $"Speed: {speed}, Color: {color}, Radius: {radius} - Fan is on";
            }
            else
            {
                return $"Color: {color}, Radius: {radius} - Fan is off";
            }
        }
    }
}
