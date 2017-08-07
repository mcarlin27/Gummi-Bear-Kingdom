using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using GummiBearKingdom.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GummiBearKingdom.Controllers
{
    public class CountriesController : Controller
    {
        private GummiBearKingdomDbContext db = new GummiBearKingdomDbContext();
        public IActionResult Index()
        {
            return View(db.Countries.Include(countries => countries.Products).ToList());
        }

        public IActionResult Details(int id)
        {
            Country thisCountry = db.Countries.Include(countries => countries.Products)
                                     .FirstOrDefault(countries => countries.CountryId == id);
            return View(thisCountry);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Country country)
        {
            db.Countries.Add(country);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisCountry = db.Countries.FirstOrDefault(countries => countries.CountryId == id);
            return View(thisCountry);
        }
        [HttpPost]
        public IActionResult Edit(Country country)
        {
            db.Entry(country).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisCountry = db.Countries.FirstOrDefault(countries => countries.CountryId == id);
            return View(thisCountry);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisCountry = db.Countries.FirstOrDefault(countries => countries.CountryId == id);
            db.Countries.Remove(thisCountry);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
