using EmployeeApprovalSystem.Data;
using EmployeeApprovalSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApprovalSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var companies = await _context.Companies.ToListAsync();
            var departments = await _context.Departments.ToListAsync();
            ViewBag.Companies = companies;
            ViewBag.Departments = departments;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            employee.Status = "Saved";
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ApproverPage()
        {
            var employees = await _context.Employees.Include(e => e.CompanyId).Include(e => e.DepartmentId).ToListAsync();
            return View(employees);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                employee.Status = "Approved";
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("ApproverPage");
        }
    }
}
