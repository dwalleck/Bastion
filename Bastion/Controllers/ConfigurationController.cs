using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bastion.Models.Compute;
using MongoDB.Bson;

namespace Bastion.Controllers
{
    public class ConfigurationController : Controller
    {

        public BastionContext Context = new BastionContext();
        
        // GET: Configuration
        public ActionResult Index()
        {
            var configs = Context.Configurations.FindAll();
            return View(configs);
        }

        // GET: Configuration/Details/5
        public ActionResult Details(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index");
            }

            var configuration = Context.Configurations.FindOneById(new ObjectId(id));
            return View(configuration);
        }

        // GET: Configuration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Configuration/Create
        [HttpPost]
        public ActionResult Create(ComputeConfiguration config)
        {
            try
            {

                Context.Configurations.Insert(config);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Configuration/Edit/5
        public ActionResult Edit(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index");
            }

            var configuration = Context.Configurations.FindOneById(new ObjectId(id));
            return View(configuration);
        }

        // POST: Configuration/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, ComputeConfiguration config)
        {
            if (String.IsNullOrEmpty(id))
            {
                return RedirectToAction("Index");
            }

            try
            {
                config.Id = new ObjectId(id);
                Context.Configurations.Save(config);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Configuration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Configuration/Delete/5
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
