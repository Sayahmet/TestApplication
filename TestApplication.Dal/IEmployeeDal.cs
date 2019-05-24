using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.BE;
using TestApplication.DB.Models;

namespace TestApplication.Dal
{
    public interface IEmployeeDal
    {
        IEnumerable<Employee> GetEmployees(string name, string position);

        Employee GetEmployee(long id);

        void AddEmployee(Employee employee);

        void UpdateEmployee(Employee employee);

        void RemoveEmployee(long id);
    }
}
