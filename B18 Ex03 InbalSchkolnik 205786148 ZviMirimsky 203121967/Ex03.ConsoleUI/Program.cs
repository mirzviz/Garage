using System;
using System.Collections.Generic;
using System.Text;
using Ex03.GarageLogic;

namespace Ex03.ConsoleUI
{
    public class Program
    {
        public static void Main()
        {
            Garage gr = new Garage();
            gr.addVehicle(new CombustionMotorcycle(new MotorcycleProperties(3, LicenseType.A1), "WheelMan", "ModelPoopi", "1234"));
            gr.addVehicle(new ElectricMotorcycle(new MotorcycleProperties(42, LicenseType.B2), "electoWheelMan", "ModelElectrico", "021"));
            gr.addVehicle(new CombustionCar(new CarProperties(Color.Gray, 4), "BebeCarWheel", "combusCar", "000"));

            Console.WriteLine(gr.ToString());

            Console.ReadLine();
        }
    }
}
