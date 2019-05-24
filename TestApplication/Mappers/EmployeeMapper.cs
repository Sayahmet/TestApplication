using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApplication.BE;
using TestApplication.Models;

namespace TestApplication.Mappers
{
    public class EmployeeMapper : IEmployeeMapper
    {
        public Employee MapToBEModel(EmployeeModel employeeVm)
        {
            return new Employee
            {
                Id = employeeVm.Id,
                Name = employeeVm.Name,
                Surname = employeeVm.Surname,
                Patronomyc = employeeVm.Patronomyc,
                Birthday = employeeVm.Birthday,
                Position = employeeVm.Position,
            };
        }

        public EmployeeModel MapToViewModel(Employee employeeBe)
        {
            return new EmployeeModel
            {
                Id = employeeBe.Id,
                Name = employeeBe.Name,
                Surname = employeeBe.Surname,
                Patronomyc = employeeBe.Patronomyc,
                Birthday = employeeBe.Birthday,
                Position = employeeBe.Position,
            };
        }
    }
}