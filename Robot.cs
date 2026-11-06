using System;
using System.Collections.Generic;
using System.Text;

namespace _6._11
{
    internal  abstract class Robot
    {
        protected bool CanPerformTask()
        {
            if (Battery < 20)
            {
                Console.WriteLine("Not enough battery!");
                return false;
            }

            return true;
        }
        public string Name {  get; set; }
        public string Model { get; set; }
        public int Battery { get; set; }
        
        public Robot(string Name, string Model, int Battery) 
        {
            this.Name = Name;
            this.Model = Model;
            this.Battery = Battery;
        }
        public abstract void PerformTask();
        public int Charge()
        {
            Battery = Math.Min(Battery + 20, 100);
            return Battery;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Baterry: {Battery}");
        }

            
    }
}
