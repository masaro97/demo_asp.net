using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Web1.Areas.Admin.Controllers
{
    public class SinhvienController : Controller
    {
        // GET: Admin/Sinhvien
        public ActionResult Index()
        {
            var iplSV = new SinhvienModel();
            var model = iplSV.ListAll();
            return View(model);
        }

        // GET: Admin/Sinhvien/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Sinhvien/Create
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Sinhvien/Create
        [HttpPost]
        public ActionResult Create(SinhvienModel collection)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
                }
                return View(collection);
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Sinhvien/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Sinhvien/Edit/5
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

        // GET: Admin/Sinhvien/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Sinhvien/Delete/5
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
        public ActionResult DS()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Sinhvien");
        }
        public ActionResult DS1()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Create", "Sinhvien");
        }
    }
}
