using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplication.Dal;
using TestApplication.Mappers;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeDal _dal;
        private readonly IEmployeeMapper _mapper;

        public EmployeeController(IEmployeeDal dal, IEmployeeMapper mapper)
        {
            _dal = dal;
            _mapper = mapper;
        }

        public ActionResult Index(string name, string position)
        {
            var employees = _dal.GetEmployees(name, position).Select(employee => _mapper.MapToViewModel(employee));
            return View(employees);
        }

        public ActionResult Edit(long id)
        {
            var employee = _mapper.MapToViewModel(_dal.GetEmployee(id));
            return View(employee);
        }

        [HttpPost]
        public ActionResult Edit(EmployeeModel employee)
        {
            _dal.UpdateEmployee(_mapper.MapToBEModel(employee));

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployeeModel employee)
        {
            _dal.AddEmployee(_mapper.MapToBEModel(employee));

            return RedirectToAction("Index");
        }

        public ActionResult Delete(long id)
        {
            _dal.RemoveEmployee(id);
            return RedirectToAction("Index");
        }
        

    }
}