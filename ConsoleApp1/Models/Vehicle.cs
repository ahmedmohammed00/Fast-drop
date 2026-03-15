using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Vehicle
    {
        public int VehicleId { get; set; }

        public string LicensePlate { get; set; }

        public string? Model { get; set; }

        public string? VehicleType { get; set; }

        public decimal? MaxCapacityKg { get; set; }

        public DateTime? LicenseExpiryDate { get; set; }

        public ICollection<DriverVehicle>? DriverVehicles { get; set; }
    }
}
