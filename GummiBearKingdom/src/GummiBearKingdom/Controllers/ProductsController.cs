using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using GummiBearKingdom.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System;

namespace GummiBearKingdom.Controllers
{
    public class ProductsController : Controller
    {
        private GummiBearKingdomDbContext db = new GummiBearKingdomDbContext();
        public IActionResult Index()
        {
            return View(db.Products.Include(products => products.Country).ToList());
        }

        public IActionResult Details(int id)
        {
            Product thisProduct = db.Products.Include(products => products.Country)
                                     .FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }
        public IActionResult Create()
        {
            if (db.Countries.Count() == 0)
            {
                return RedirectToAction("Create", "Countries");
            }
            else
            {
                ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
                return View();
            }
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            ViewBag.CountryId = new SelectList(db.Countries, "CountryId", "Name");
            return View(thisProduct);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            db.Products.Remove(thisProduct);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
