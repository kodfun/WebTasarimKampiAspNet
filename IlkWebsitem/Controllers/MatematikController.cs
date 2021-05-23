using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IlkWebsitem.Controllers
{
    public class MatematikController : Controller
    {
        // Matematik/Index?sayi1=3&sayi2=4
        public IActionResult Index(int sayi1 = 0, int sayi2 = 0)
        {
            ViewData["Sayi1"] = sayi1;
            ViewData["Sayi2"] = sayi2;
            ViewData["Toplam"] = sayi1 + sayi2;
            return View();
        }
    }
}
