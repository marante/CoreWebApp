using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreWebApp.Data
{
    /// <summary>
    /// Represents a employee entity within the system.
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // TODO Ask about this, not sure if this is necessary.
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        // Poor naming, but will keep it like this until I have spoken with sh.
        public List<Role> Role { get; set; }

        public List<WorkorderEmployees> WorkorderEmployees { get; set; }
    }
}