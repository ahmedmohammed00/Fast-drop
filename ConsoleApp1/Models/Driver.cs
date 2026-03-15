using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Driver
    {
        public int DriverId { get; set; }

        public string Name { get; set; }

        public string? PhoneNumber { get; set; }

        public string? LicenseNumber { get; set; }

        public DateTime? LicenseExpiryDate { get; set; }

        public string CurrentStatus { get; set; } = "available";

        public int? ZoneId { get; set; }

        public int? AddressId { get; set; }

        public int? EmployeeId { get; set; }

        public Zone? Zone { get; set; }

        public Address? Address { get; set; }

        public Employee? Employee { get; set; }

        public ICollection<DriverVehicle>? DriverVehicles { get; set; }

        public ICollection<DriverRoute>? DriverRoutes { get; set; }
    }
}
