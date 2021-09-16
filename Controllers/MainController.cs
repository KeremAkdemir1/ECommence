using E_Commence.Models.Data;
using E_Commence.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commence.Controllers
{
    public class MainController : Controller
    {
        Context c = new Context();
        FoodRepository fr = new FoodRepository();
        public IActionResult Index()
        {
            return View(fr.TList());
        }
        public IActionResult Foods()
        {
            return View(fr.TList());
        }
        public IActionResult FastFoods()
        {
            return View(fr.List(x=>x.CategoryID == 1));
        }
    }
}
