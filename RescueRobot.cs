using System;
using System.Collections.Generic;
using System.Text;

namespace _6._11
{
    internal class RescueRobot : Robot
    {
        public int Sensors { get; set; }
        public RescueRobot(int Sensors, string Name, string Model, int Battery) : base(Name, Model, Battery)
        {
            this.Sensors = Sensors;
        }
        public override void PerformTask()
        {
            if (!CanPerformTask())
                return;

            Console.WriteLine("The robot is on a rescue mission");

            Battery = Math.Max(0, Battery - 30);
        }
    }
}
