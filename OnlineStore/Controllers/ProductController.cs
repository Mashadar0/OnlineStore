using Microsoft.AspNetCore.Mvc;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class ProductController : Controller
    {
        StoreContext db;
        public ProductController(StoreContext context)
        {
            db = context;
        }

        public IActionResult Product_Index()
        {
            return View(db.Products.ToList());
        }
    }

}
