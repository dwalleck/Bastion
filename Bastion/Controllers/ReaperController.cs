using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bastion.Controllers
{
    public class ReaperController : Controller
    {

        public BastionContext Context = new BastionContext();

        // GET: Reaper
        public ActionResult Index()
        {
            var accounts = Context.Accounts.FindAll();
            return View(accounts);
        }

        // GET: Reaper/Details/5
        public ActionResult Details(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index");
            }

            var account = Context.Accounts.FindOneById(new ObjectId(id));
            return View(account);
        }

        // GET: Reaper/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reaper/Create
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

        // GET: Reaper/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reaper/Edit/5
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

        // GET: Reaper/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reaper/Delete/5
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
