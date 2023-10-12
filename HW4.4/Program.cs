using HW4._4.Models;

namespace HW4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car1 = new Car("BMW","X6",50,500,4,true);
            Vehicle car2 = new Car("BMW","X7",50,500,4,true);
            Vehicle car3 = new Car("BMW","X5",50,500,4,true);

            Vehicle bicycle1 = new Bicylce("Abici", "Yamaha", 10, 100, "Mountain bike");
            Vehicle bicycle2 = new Bicylce("Abici2", "Yamaha", 20, 200, "Tandem bike");
            Vehicle bicycle3 = new Bicylce("Abici3", "Yamaha", 10, 200, "Road bike");

            Vehicle[] vehicles = new Vehicle[]
            { car1, car2,car3,bicycle1,bicycle2,bicycle3};
            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine();
                v.GetInfo();
            }
        }
    }
}