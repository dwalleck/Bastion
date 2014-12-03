﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bastion.Controllers
{
    public class BuildResultsController : Controller
    {
        public BastionContext Context = new BastionContext();

        // GET: BuildResults
        public ActionResult Index()
        {
            var results = Context.Results.FindAll();
            return View(results);
        }

        // GET: BuildResults/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BuildResults/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BuildResults/Create
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

        // GET: BuildResults/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BuildResults/Edit/5
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

        // GET: BuildResults/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuildResults/Delete/5
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
