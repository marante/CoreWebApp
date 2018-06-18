using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreWebApp.Data
{
    /// <summary>
    /// Represents a entity within the system.
    /// </summary>
    public class Workorder
    {
        public int Id { get; set; }
        public string ObjNr { get; set; }
        public DateTime DateAdded { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Start { get; set; }
        public string Status { get; set; }
        public string SentInvoice { get; set; }
        public List<WorkorderEmployees> WorkorderEmployees { get; set; }
    }
}