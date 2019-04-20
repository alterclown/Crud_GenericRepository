using GenericRepo.DAL;
using GenericRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenericRepo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        private IAllRepository<Person> db;
        private IAllRepository<test> db1;

        public EmployeeController()
        {
            db = new AllRepository<Person>();
            db1 = new AllRepository<test>();
        }
        public ActionResult Index()
        {
            return View(db.getModel());
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            //List<test> list = db1.getModel().ToList();
            //ViewBag.list = new SelectList(list,"OrderID","OrderNumber");
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                // TODO: Add insert logic here

                db.insertModel(person);
                db.save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            return View(db.getModelById(id));
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Person person)
        {
            try
            {
                // TODO: Add update logic here
                db.updateModel(person);
                db.save();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.getModelById(id));
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                db.deleteModel(Id);
                db.Remove(Id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
