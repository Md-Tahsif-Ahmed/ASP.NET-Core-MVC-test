// EmployeeController.cs
using EmployeeApprovalSystem.Models;
using EmployeeApprovalSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace EmployeeApprovalSystem.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employee Entry Form
        [HttpGet]
        public IActionResult AddEmployeeForm()
        {
            ViewBag.Companies = new SelectList(_context.Companies.ToList(), "CompanyId", "CompanyName");
            ViewBag.Departments = new SelectList(_context.Departments.ToList(), "DepartmentId", "DepartmentName");
            return View();
        }

        // POST: Add Employee to Database
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return RedirectToAction("Index", "Employee"); // Redirect to employee list or success page
            }

            // Re-populate ViewBag in case of validation errors
            ViewBag.Companies = new SelectList(_context.Companies.ToList(), "CompanyId", "CompanyName");
            ViewBag.Departments = new SelectList(_context.Departments.ToList(), "DepartmentId", "DepartmentName");

            return View("AddEmployeeForm", employee); // Return to the form with the current data
        }
    }
}
