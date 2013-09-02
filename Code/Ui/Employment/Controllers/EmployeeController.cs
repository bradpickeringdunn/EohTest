using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EohTest.Ui.Employment.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var employee = new Models.EmployeeModel();
            employee.GetEmployees(); 
            return View(employee);
        }

        [HttpPut]
        public ActionResult DismissEmployee(int id)
        {
            int employeeId;

            if (Request.IsAjaxRequest())
            {
                employeeId = id;
            }
            else
            {
                string employee = "employees";
                employeeId = int.Parse(Request.Form[employee].ToString());
            }
                
            new Models.EmployeeModel().DismissEmployee(employeeId);

            Index();
            return View("Index");
        }

        [HttpPost]
        public ActionResult Create()
        {
            try
            {
                int personId = int.Parse(Request.Form["candidates"]);
                new EohTest.Service.Crud.Controllers.EmploymentController().AddEmployee(personId);
                return RedirectToAction("Index");
            }
            catch (DuplicateWaitObjectException ex)
            {
                if (Request.IsAjaxRequest())
                {
                    return Json(ex.Message);
                }
                else
                {
                    ViewBag.errorMessage = ex.Message;
                    return View("Create");
                }
                
            }
        }

        
    }
}
