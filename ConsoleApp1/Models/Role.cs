using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string? PermissionsDescription { get; set; }

        public ICollection<Employee>? Employees { get; set; }
    }

}
