using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bastion.Controllers
{
    public class CafeResultsController : Controller
    {
        public CafeContext Context = new CafeContext();

        // GET: CafeResults
        public ActionResult Index()
        {
            var configs = Context.ComputeContexts.FindAll();
            return View(configs);
        }

        // GET: CafeResults/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CafeResults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CafeResults/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CafeResults/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CafeResults/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CafeResults/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CafeResults/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
