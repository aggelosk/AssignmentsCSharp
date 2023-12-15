namespace Assignment4
{
    public interface IVehicle
    {
        public void Drive();

        public bool Refuel(int gas);
    }

    public class Car : IVehicle
    {
        private int _gas;
    
        public Car(int gas)
        {
            _gas = gas;
        }
    
        public void Drive()
        {
            if (_gas > 0)
                Console.WriteLine("Driving...");
        }

        public bool Refuel(int gas)
        {
            _gas += gas;
            return true;
        }
    }
    
    class VehicleTest
    {
        static void Main()
        {
            Car car = new Car(0);
            Console.WriteLine("Enter the amount of gas:");
            Int32.TryParse(Console.ReadLine(), out int gas);
    
            car.Refuel(gas);
            car.Drive();
        
        }
    }
}