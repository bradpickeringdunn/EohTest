﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EOHTest.Ui.Web.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var employee = new Models.EmployeeModel();
            employee.GetEmployees(); 
            return View(employee);
        }

        public ActionResult DismissEmployee(int employeId)
        {
            new Models.EmployeeModel().DismissEmployee(employeId);

            Index();
            return View("Index");
        }

        [HttpPost]
        public ActionResult Create(int candidatesId)
        {
            try
            {
                //int personId = int.Parse(Request.Form["candidates"]);
                new EOHTest.Service.Crud.Controllers.EmploymentController().AddEmployee(candidatesId);
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
