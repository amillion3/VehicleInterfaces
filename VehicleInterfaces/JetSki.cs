using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterfaces
{
    class JetSki : IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; }
        public string TransmissionType { get; set; } = "Standard";
        public double EngineVolume { get; set; } = 1498;
        public double MaxWaterSpeed { get; set; } = 65;
        public double MaxLandSpeed { get; set; } = 0;
        public double MaxAirSpeed { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("My friend once ran his Jetski into mine. His dad was pissed!");
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
