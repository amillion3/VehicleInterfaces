using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    class FordGT : IVehicle
    {
        public int Wheels { get; set; } = 4;
        public int Doors { get; set; } = 2;
        public int PassengerCapacity { get; set; } = 2;
        public bool Winged { get; set; }
        public string TransmissionType { get; set; } = "6 speed manual";
        public double EngineVolume { get; set; } = 5409.6;
        public double MaxWaterSpeed { get; set; } = 0;
        public double MaxLandSpeed { get; set; } = 205;
        public double MaxAirSpeed { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("A Ferrari killer, powered by a truck engine.");
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
