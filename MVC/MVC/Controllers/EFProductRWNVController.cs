using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using System.Data.Entity;

namespace MVC.Controllers
{
    public class EFProductRWNVController : Controller
    {

        public ActionResult Index()
        {
            using (MvcCrudDBEntities model = new MvcCrudDBEntities())
            {
                return View(model.Products.ToList());
            }
        }

        public ActionResult Details(int id)
        {
            using (MvcCrudDBEntities model = new MvcCrudDBEntities())
            {
                return View(model.Products.Where(x => x.ProductID == id).FirstOrDefault());
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                using (MvcCrudDBEntities model = new MvcCrudDBEntities())
                {
                    model.Products.Add(product);
                    model.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            using (MvcCrudDBEntities model = new MvcCrudDBEntities())
            {
                return View(model.Products.Where(x => x.ProductID == id).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                using (MvcCrudDBEntities model = new MvcCrudDBEntities())
                {
                    model.Entry(product).State = EntityState.Modified;
                    model.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            using (MvcCrudDBEntities model = new MvcCrudDBEntities())
            {
                return View(model.Products.Where(x => x.ProductID == id).FirstOrDefault());
            }
        }

        [HttpPost]
        public ActionResult Delete(int id,Product product)
        {
            try
            {
                using (MvcCrudDBEntities model = new MvcCrudDBEntities())
                {
                    Product pm = model.Products.Where(x => x.ProductID == id).FirstOrDefault();
                    model.Products.Remove(pm);
                    model.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }       
        }

    }
}
