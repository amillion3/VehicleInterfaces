using System;
using System.Linq;
using System.Collections.Generic;
using Vehicles;

namespace VehicleInterfaces
{
    public class Program
    {
        public static void Main()
        {
            // Air travel
            List<IVehicle> AeroPlanes = new List<IVehicle>
            {
                new Cessna(),
                new DracoBushPlane()
            };
            foreach (IVehicle a in AeroPlanes)
            {
                a.Fly();
            }
            Console.WriteLine("");

            // Land travel
            List<IVehicle> MotorVehicles = new List<IVehicle>
            {
                new FordGT(),
                new Motorcycle()
            };
            foreach (IVehicle m in MotorVehicles)
            {
                m.Drive();
            }
            Console.WriteLine("");

            // Water travel
            List<IVehicle> WaterVehicles = new List<IVehicle>
            {
                new JetSki(),
                new TugBoat()
            };
            foreach (IVehicle w in WaterVehicles)
            {
                w.Drive();
            }

            Console.ReadLine();
        }
    }
}
