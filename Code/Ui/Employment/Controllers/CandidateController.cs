using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EOHTest.Ui.Web.Controllers
{
    public class CandidateController : Controller
    {
        public ActionResult Index()
        {
            var candidates = new Models.CandidateModel();

            return View(candidates);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult RemoveCandidate(int? id)
        {
            if (!Request.IsAjaxRequest())
            {
                id = int.Parse(Request.Form["candidates"].ToString());
            }

            new Models.CandidateModel().DeleteCandidate(id.Value);
            DeleteCandidate();
            return View("DeleteCandidate");
        }

   
        public ActionResult DeleteCandidate()
        {
            var candidates = new Models.CandidateModel();
            return View(candidates);
        }

        [HttpPost]
        public ActionResult Create(string firstname, string lastName, string dateOfBirth)
        {
            new EOHTest.Service.Crud.Controllers.PersonController().Create(firstname, lastName, dateOfBirth);

            var candidates = new Models.CandidateModel();
            return View("Index", candidates);

        }

        [HttpGet]
        public ActionResult Edit()
        {
            var candidates = new Models.CandidateModel();
            candidates.GetCandidates();
            return View("Delete", candidates);
        }

    }
}
