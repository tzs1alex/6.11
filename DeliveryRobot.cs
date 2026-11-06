using System;
using System.Collections.Generic;
using System.Text;

namespace _6._11
{
    internal class DeliveryRobot: Robot
    {

        public string DeliveryAddress {  get; set; }

        public DeliveryRobot(string DeliveryAddres, string Name,string Model, int Battery): base(Name, Model, Battery)
        {
            this.DeliveryAddress = DeliveryAddres;
        }
        public override void PerformTask()
        {
            if (!CanPerformTask())
                return;

            Console.WriteLine("The delivery is here");

            Battery = Math.Max(0, Battery - 15);
        }

    }
}
