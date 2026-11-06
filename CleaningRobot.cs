using System;
using System.Collections.Generic;
using System.Text;

namespace _6._11
{
    internal class CleaningRobot: Robot
    {
        public double Area { get; set; }
        public CleaningRobot(double Area , string Name, string Model, int Battery) : base(Name, Model, Battery)
        {
            this.Area = Area;
        }
        public override void PerformTask()
        {
            if (!CanPerformTask())
                return;

            Console.WriteLine("The robot is cleaning");

            Battery = Math.Max(0, Battery - 25);
        }
    }
}
