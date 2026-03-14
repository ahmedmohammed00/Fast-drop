using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string AccountStatus { get; set; } = "active";

        public int? RoleId { get; set; }

        public int? SupervisorId { get; set; }

        public Role? Role { get; set; }

        public Employee? Supervisor { get; set; }

        public ICollection<Employee>? Subordinates { get; set; }

        public ICollection<Driver>? Drivers { get; set; }

    }
}
