using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApplication.BE;
using TestApplication.Models;

namespace TestApplication.Mappers
{
    public interface IEmployeeMapper
    {
        EmployeeModel MapToViewModel(Employee employeeBe);
        Employee MapToBEModel(EmployeeModel employeeVm);
    }
}
