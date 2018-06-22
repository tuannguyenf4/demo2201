using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCore2MVC.Models;
using ASPNETCore2MVC.ViewModel;

namespace ASPNETCore2MVC.IService
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task<Employee> AddEmployee(EmployeeViewModel emp);
        Task<Employee> UpdateEmployee(EmployeeViewModel emp);
        Task<int> DeleteEmployee(int emp);
    }
}
