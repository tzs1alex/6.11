namespace _6._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryRobot robot1 = new DeliveryRobot(
                "Sofia", "Robo1", "D100", 80);

            CleaningRobot robot2 = new CleaningRobot(
                150, "Robo2", "C200", 60);

            RescueRobot robot3 = new RescueRobot(
                8, "Robo3", "R300", 40);

            List<Robot> robots = new List<Robot>()
            {
                robot1,
                robot2,
                robot3
            };

            foreach (Robot robot in robots)
            {
                robot.ShowInfo();
                Console.WriteLine();
            }

            foreach (Robot robot in robots)
            {
                robot.PerformTask();
                Console.WriteLine("Battery: " + robot.Battery + "%");
                Console.WriteLine();
            }

            foreach (Robot robot in robots)
            {
                robot.Charge();
                Console.WriteLine(robot.Name + " charged: " + robot.Battery + "%");
            }

            Console.ReadKey();
        }
    }
}
