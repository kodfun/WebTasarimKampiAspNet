using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IlkWebsitem.Controllers
{
    public class AnkaraController : Controller
    {
        // [Controller]/[Action]
        // Ankara/Nufus
        public string Nufus()
        {
            return "Ankara'nın Nüfusu: 5663000";
        }

        // Ankara/Ilceler
        public IActionResult Ilceler()
        {
            ViewBag.ToplamIlceAdedi = 25; // controller'dan view'e veri taşıyoruz
            return View();
        }
    }
}
