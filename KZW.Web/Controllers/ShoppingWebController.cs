using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KZW.Web.Controllers
{
    public class ShoppingWebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
