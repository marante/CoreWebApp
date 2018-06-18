namespace CoreWebApp.Data
{
    public class WorkorderEmployees
    {
        public int WorkorderId { get; set; }
        public Workorder Workorder { get; set; }
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}