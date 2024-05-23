using Microsoft.EntityFrameworkCore;

namespace BlazorCRUDWithAuthentication.Data
{
    public class EmployeeService  /*IEmployeeService*/
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        ////Create Employee
        //public async Task<bool> CreateEmployee(Employee employee)
        //{
        //    await _appDbContext.Employees.AddAsync(employee);
        //       await _appDbContext.SaveChangesAsync();
        //        return true;
        //}

        //public async Task<bool> DeleteEmployee(Employee employee)
        //{
        //    _appDbContext.Remove(employee);
        //       await _appDbContext.SaveChangesAsync();
        //       return true;
        //}

        ////Get All List
        //public async Task<List<Employee>> GetAllEmployees()
        //{
        //    return await _appDbContext.Employees.ToListAsync();
        //}

        ////Get Employee By Id
        //public async Task<Employee> GetEmployee(int Id)
        //{
        //    Employee employee = await _appDbContext.Employees.FirstOrDefaultAsync(c => c.Id.Equals(Id));
        //    if (employee == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        await _appDbContext.Employees.FindAsync(Id);
        //    }
        //    return employee;
        //}


        ////Update Employee
        //public async Task<bool> UpdateEmployee(Employee employee)
        //{
        //    _appDbContext.Employees.Update(employee);
        //       await _appDbContext.SaveChangesAsync();
        //        return true;
        //}





        //Get All List
        public async Task<List<Employee>> GetAllEmployeesAsync()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        //Create Employee
        public async Task<bool> CreateEmployeeAsync(Employee employee)
        {
            await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        //Get Employee By Id
        public async Task<Employee> GetEmployeeAsync(int Id)
        {
            Employee employee = await _appDbContext.Employees.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return employee;
        }

        //Update Employee
        public async Task<bool> UpdateEmployeeAsync(Employee employee)
        {
            _appDbContext.Employees.Update(employee);
            await _appDbContext.SaveChangesAsync();
            return true;
        }

        //Delete Employee
        public async Task<bool> DeleteEmployeeAsync(Employee employee)
        {
            _appDbContext.Remove(employee);
            await _appDbContext.SaveChangesAsync();
            return true;

        }
    }
}