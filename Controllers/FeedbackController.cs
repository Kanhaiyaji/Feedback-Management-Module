using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using FeedbackManagement.Models;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        // Each browser session keeps its own feedback list.
        private List<Feedback> Entries
        {
            get
            {
                if (Session["Feedback"] == null)
                    Session["Feedback"] = new List<Feedback>();
                return (List<Feedback>)Session["Feedback"];
            }
        }
        public ActionResult Index()
        {
            return View(Entries.OrderByDescending(f => f.Id).ToList());
        }
        public ActionResult Create()
        {
            return View(new Feedback());
        }
        [HttpPost, ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include =
            "StudentName,Email,Subject,Rating,Comments")] Feedback feedback)
        {
            if (!ModelState.IsValid)
                return View(feedback);
            feedback.Id = Entries.Count + 1;
            feedback.SubmittedAt = DateTime.Now;
            Entries.Add(feedback);
            TempData["Success"] = "Feedback submitted successfully!";
            return RedirectToAction("Index");
        }
    }
}
