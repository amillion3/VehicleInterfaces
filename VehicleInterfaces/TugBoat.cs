using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleInterfaces
{
    class TugBoat : IVehicle
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int PassengerCapacity { get; set; } = 12;
        public bool Winged { get; set; }
        public string TransmissionType { get; set; } = "Standard";
        public double EngineVolume { get; set; } = 279235.57;
        public double MaxWaterSpeed { get; set; } = 15;
        public double MaxLandSpeed { get; set; } = 0;
        public double MaxAirSpeed { get; set; } = 0;

        public void Drive()
        {
            Console.WriteLine("Tugboats rule!");
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
