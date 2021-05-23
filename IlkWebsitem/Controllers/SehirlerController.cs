using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IlkWebsitem.Controllers
{
    public class SehirlerController : Controller
    {
        // Sehirler/Bilgi/1
        public IActionResult Bilgi(int id)
        {
            string bilgi;

            switch (id)
            {
                case 6:
                    bilgi = "Ankara Türkiye'nin başkentidir.";
                    break;
                case 34:
                    bilgi = "İstanbul Türkiye'nin en kalabalık şehridir.";
                    break;
                case 1:
                    bilgi = "Adana'da adana kebap yiyebilirsiniz.";
                    break;
                default:
                    bilgi = "Böyle bir şehir bulunamadı";
                    break;
            }

            return View(model: bilgi);
        }
    }
}
