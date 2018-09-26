namespace LogNoziroh.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class ReportController : Controller
    {
        private readonly LogNozirohDbContext dbContext;

        public ReportController(LogNozirohDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Report> reports = this.dbContext
                .Reports
                .ToList();

            return View(reports);
        }

        [HttpGet]
        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            var report = this.dbContext.Reports.Find(id);

            return View(report);
        }

        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Report report)
        {
            this.dbContext.Reports.Add(report);
            this.dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var report = this.dbContext
                .Reports
                .Where(p => p.Id == id)
                .FirstOrDefault();

            return View(report);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int id, Report reportModel)
        {
            var report = this.dbContext
               .Reports
               .Where(p => p.Id == id)
               .FirstOrDefault();

            this.dbContext.Remove(report);
            this.dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
