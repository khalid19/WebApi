using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDWebAPI_Client.Models;
using CRUDWebAPI_Client.ViewModels;

namespace CRUDWebAPI_Client.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/
        public ActionResult Index()
        {
            ProductCleint pc = new ProductCleint();
            ViewBag.listProducts = pc.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
           
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel pvm)
        {
            pvm.Product.CreationDate = DateTime.Now;
            ProductCleint pc = new ProductCleint();
            pc.Create(pvm.Product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            ProductCleint pc = new ProductCleint();
            pc.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ProductCleint pc = new ProductCleint();
            ProductViewModel pvm = new ProductViewModel();
            pvm.Product = pc.find(id);
            return View("Edit",pvm);
        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel pvm)
        {
            ProductCleint pc = new ProductCleint();
            pc.Edit(pvm.Product);
            return RedirectToAction("Index");
        }
	}
}