namespace EmployeeApprovalSystem.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? EmployeeName { get; set; }
        public string? Designation { get; set; }
        public int CompanyId { get; set; }
        public int DepartmentId { get; set; }
        public string? Status { get; set; }
    }
}
