using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KZW.Web.Controllers
{
    public class GoodsWebController : Controller
    {
        public IActionResult ActivePage()
        {
            return View();
        }

        public IActionResult Shop1Page()
        {
            return View();
        }

        public IActionResult BuyPage()
        {
            return View();
        }
    }
}
