using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class DracoBushPlane : IVehicle
    {
        public int Wheels { get; set; } = 3;
        public int Doors { get; set; } = 3;
        public int PassengerCapacity { get; set; } = 4;
        public bool Winged { get; set; } = true;
        public string TransmissionType { get; set; } = "None";
        public double EngineVolume { get; set; } = 9999.9;
        public double MaxWaterSpeed { get; set; } = 0;
        public double MaxLandSpeed { get; set; } = 0;
        public double MaxAirSpeed { get; set; } = 250;

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("I have a plane that can go to 28,000 feet and do 180mph cross-country with four people and gear. To me, that makes it the ultimate bush plane.");
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
