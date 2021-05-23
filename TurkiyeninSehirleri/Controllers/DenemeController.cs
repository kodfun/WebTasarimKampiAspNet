using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TurkiyeninSehirleri.Controllers
{
    public class DenemeController : Controller
    {
        // Deneme/Index
        public string Index()
        {
            return "Merhaba! Bu bir denemedir.";
        }
    }
}
