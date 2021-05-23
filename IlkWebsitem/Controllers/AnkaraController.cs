using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkWebsitem.Controllers
{
    public class AnkaraController : Controller
    {
        // [Controller]/[Action]
        // Ankara/Nufus
        public string Nufus()
        {
            return "Ankara'nın Nüfusu: 5663000"; // düz metin (plain text)
        }

        // Ankara/Ilceler
        public IActionResult Ilceler()
        {
            ViewBag.ToplamIlceAdedi = 25; // controller'dan view'e veri taşıyoruz
            return View(); // html
        }

        public IActionResult GezilecekYerler()
        {
            List<string> yerler = new List<string>()
            {
                "Anıtkabir", "Kızılay Meydanı", "Güvenpark", "Kocatepe Camisi", "Hacı Bayram Veli Camisi", "Ankara Kalesi", "Hamamönü"
            };
            return View(yerler);
        }

        // Ankara/GezilecekYerlerJson
        public IActionResult GezilecekYerlerJson()
        {
            List<string> yerler = new List<string>()
            {
                "Anıtkabir", "Kızılay Meydanı", "Güvenpark", "Kocatepe Camisi", "Hacı Bayram Veli Camisi", "Ankara Kalesi", "Hamamönü"
            };
            return Json(yerler);
        }

        // Ankara/Goller
        public IActionResult Goller()
        {
            return Content(@"
<h1>Ankara'nın Gölleri</h1>
<ul>
    <li>Mogan Gölü</li>
    <li>Mavi Göl</li>
    <li>Eymir Gölü</li>
</ul>", "text/html", Encoding.UTF8);
        }
    }
}
