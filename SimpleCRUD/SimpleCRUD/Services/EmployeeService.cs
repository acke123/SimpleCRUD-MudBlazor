using Microsoft.EntityFrameworkCore;
using SimpleCRUD.DataAccess;
using SimpleCRUD.DataAccess.Entities;
using SimpleCRUD.ViewModels;
using System.Linq.Expressions;

namespace SimpleCRUD.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext dbContext;

        public EmployeeService(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<EmployeeViewModel>> GetAllEmployees()
        {
            //return await dbContext.Employees.ToListAsync();
            return await dbContext.Employees
                .OrderBy(x=>x.FullName)
                .Select(x=> new EmployeeViewModel
                {
                    EmployeeId = x.EmployeeId,
                    FullName = x.FullName,
                    Department = x.Department,
                    DateOfBirth = x.DateOfBirth,
                    Age = x.Age,
                    PhoneNumber = x.PhoneNumber,
                }).ToListAsync();
        }

        public async Task<bool> CreateNewEmployee(EmployeeViewModel model)
        {
            try
            {
                Employee employee = new Employee
                {
                    FullName = model.FullName,
                    Department = model.Department,
                    DateOfBirth = model.DateOfBirth,
                    Age = model.Age,
                    PhoneNumber = model.PhoneNumber,
                };

                dbContext.Employees.Add(employee);
                var result = await dbContext.SaveChangesAsync();

                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateEmployee(EmployeeViewModel model)
        {
            try
            {
                var employee = await dbContext.Employees.FindAsync(model.EmployeeId);
                if (employee == null)
                {
                    return false;
                }

                employee.FullName = model.FullName;
                employee.Department = model.Department;
                employee.DateOfBirth = model.DateOfBirth;
                employee.Age = model.Age;
                employee.PhoneNumber = model.PhoneNumber;

                dbContext.Employees.Update(employee);
                var result = await dbContext.SaveChangesAsync();

                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteEmployee(int employeeId)
        {
            try
            {
                var employee = await dbContext.Employees.FindAsync(employeeId);
                if (employee == null)
                {
                    return false;
                }

                dbContext.Employees.Remove(employee);
                var result = await dbContext.SaveChangesAsync();

                return result > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
