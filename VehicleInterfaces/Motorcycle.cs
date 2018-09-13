using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterfaces
{
    class Motorcycle : IVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; }
        public string TransmissionType { get; set; } = "6 speed sequential gear box";
        public double EngineVolume { get; set; } = 749;
        public double MaxWaterSpeed { get; set; } = 0;
        public double MaxLandSpeed { get; set; } = 160;
        public double MaxAirSpeed { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("A Ducati.");
        }

        public void Fly()
        {
            throw new NotImplementedException();
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
