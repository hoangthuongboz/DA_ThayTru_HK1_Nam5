using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebClient.Models;

namespace WebClient.Areas.Administrator.Controllers
{
    [Area("administrator")]
    public class SummaryController : Controller
    {
        SummaryAppService app = new SummaryAppService();
        static Summary summaryModel = new Summary();
        // GET: SummaryController
        public ActionResult Index(Summary obj)
        {
            summaryModel = obj;
            return View();
        }
        [HttpGet]
        public IActionResult Rpt_DanhThuHaiNamGanNhat()
        {
            return Json(app.RPT_DoanhThuHaiNamGanNhat());
        }
        [HttpPost]
        public IActionResult GetSummaryCategoriesByTime()
        {
            return Json(app.GetSummaryCategoriesByTime(summaryModel));
        }
        [HttpPost]
        public IActionResult RPT_TrangThaiDonHang()
        {
            return Json(app.RPT_TrangThaiDonHang(summaryModel));
        }
        
        // GET: SummaryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SummaryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SummaryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SummaryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SummaryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SummaryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SummaryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
