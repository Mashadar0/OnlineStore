using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        StoreContext db;
        public HomeController(StoreContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Categories.ToList());
        }
    }
}
