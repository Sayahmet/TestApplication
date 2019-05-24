using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.BE;
using TestApplication.DB;
using TestApplication.DB.Models;

namespace TestApplication.Dal
{
    public class EmployeeDal : IEmployeeDal
    {
        public void AddEmployee(Employee employee)
        {
            using (var context = new TestDbContext())
            {
                context.Employees.Add(MapToDbModel(employee));

                context.SaveChanges();
            }
        }

        public Employee GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployee(long id)
        {
            using (var context = new TestDbContext())
            {
               return MapToBE(context.Employees.Find(id));
            }
        }

        public IEnumerable<Employee> GetEmployees(string name, string position)
        {
            using(var context = new TestDbContext())
            {
                IQueryable<EmployeeDbModel> res;

                if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(position))
                    res = context.Employees;
                else if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(position))
                    res = context.Employees.Where(e => e.Name == name && e.Position == position);
                else if (!string.IsNullOrEmpty(name) && string.IsNullOrEmpty(position))
                    res = context.Employees.Where(e => e.Name == name);
                else
                    res = context.Employees.Where(e => e.Position == position);

                return res.ToList().Select(e => MapToBE(e));
            }
        }

        public void RemoveEmployee(long id)
        {
            using (var context = new TestDbContext())
            {
                var employee = context.Employees.Find(id);
                context.Employees.Remove(employee);

                context.SaveChanges();
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (var context = new TestDbContext())
            {
                var e = context.Employees.Find(employee.Id);

                e.Name = employee.Name;
                e.Surname = employee.Surname;
                e.Patronomyc = employee.Patronomyc;
                e.Position = employee.Position;
                e.Birthday = employee.Birthday;

                context.SaveChanges();
            }
        }

        private Employee MapToBE(EmployeeDbModel employee)
        {
            return new Employee
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                Patronomyc = employee.Patronomyc,
                Birthday = employee.Birthday,
                Position = employee.Position,
            };
        }

        private EmployeeDbModel MapToDbModel(Employee employee)
        {
            return new EmployeeDbModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                Patronomyc = employee.Patronomyc,
                Birthday = employee.Birthday,
                Position = employee.Position,
            };
        }
    }
}
