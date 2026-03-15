using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class DriverVehicle
    {
        public int DriverId { get; set; }

        public int VehicleId { get; set; }

        public Driver Driver { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
