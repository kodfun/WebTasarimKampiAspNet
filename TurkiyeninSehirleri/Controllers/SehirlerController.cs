using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurkiyeninSehirleri.Models;

namespace TurkiyeninSehirleri.Controllers
{
    public class SehirlerController : Controller
    {
        private readonly UygulamaDbContext _db;

        public SehirlerController(UygulamaDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Sehir> sehirler = _db.Sehirler.ToList();
            return View(sehirler);
        }

        public IActionResult Yeni()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Yeni(Sehir sehir)
        {
            // veriler geçerli ise
            if (ModelState.IsValid)
            {
                _db.Sehirler.Add(sehir);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(); // hata olması durumunda formu tekrar göster ki hatasını düzeltsin
        }
    }
}
