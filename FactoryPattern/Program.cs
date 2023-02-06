namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of vehicle do you want to make? A Car or Motorcycle?");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.CreateVehicle(userInput);
            myVehicle.Drive();
            
        }
    }
}

    