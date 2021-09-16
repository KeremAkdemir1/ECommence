using E_Commence.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using E_Commence.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_Commence.Controllers 
{
    public class AdminController : Controller
    {
        Context c = new Context();
        BeverageRepository br = new BeverageRepository();
        FoodRepository fr = new FoodRepository();
        VegetableRepository vr = new VegetableRepository();
        UserRepository ur = new UserRepository();
        BlogRepository blr = new BlogRepository();

        [Authorize]
        public IActionResult BeverageIndex()
        {
            return View(br.TList());
        }
        public IActionResult FoodIndex()
        {
            return View(fr.TList("Category"));
        }
        public IActionResult VegetableIndex()
        {
            return View(vr.TList());
        }
        public IActionResult UsersIndex()
        {
            return View(ur.TList());
        }
        public IActionResult BlogIndex()
        {
            return View(blr.TList());
        }

        [HttpGet]
        public IActionResult AddBeverage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddFood()
        {
            List<SelectListItem> values = (from x in c.FoodCategories.ToList()
                                           select new SelectListItem
                                           {

                                               Text = x.FoodCategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();

            ViewBag.v1 = values;
            return View();
        }

        [HttpGet]
        public IActionResult AddVegetable()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBeverage(Beverage b)
        {
            if (!ModelState.IsValid) {

                return RedirectToAction("AddBeverage", "Admin");
            
            }
            br.TAdd(b);
            return RedirectToAction("BeverageIndex","Admin");
        }

        [HttpPost]
        public IActionResult AddFood(Food f)
        {
            if (!ModelState.IsValid)
            {

                return RedirectToAction("AddFood", "Admin");

            }
            fr.TAdd(f);
            return RedirectToAction("FoodIndex","Admin");
        }

        [HttpPost]
        public IActionResult AddVegetable(Vegetable v)
        {
            if (!ModelState.IsValid)
            {

                return RedirectToAction("AddVegetable", "Admin");

            }
            vr.TAdd(v);
            return RedirectToAction("VegetableIndex","Admin");
        }


        public IActionResult DeleteFood(int id)
        {
           fr.TDelete(new Food {FoodId=id });
            return RedirectToAction("FoodIndex","Admin");
            
        }
        public IActionResult DeleteUser(int id)
        {
            ur.TDelete(new User { UserId = id });
            return RedirectToAction("UserIndex", "Admin");

        }
        public IActionResult DeleteVegetable(int id)
        {
            vr.TDelete(new Vegetable { VegetableId = id });
            return RedirectToAction("VegetableIndex", "Admin");

        }
        public IActionResult DeleteBeverage(int id)
        {
            br.TDelete(new Beverage { BeverageId = id });
            return RedirectToAction("BeverageIndex", "Admin");

        }

        [HttpGet]
        public IActionResult FoodGet(int id)
        {
            var x = fr.TGetById(id);
            Food f = new Food()
            {
                FoodId = x.FoodId,
                FoodName = x.FoodName,
                FoodPrice = x.FoodPrice,
                FoodPhotoLink = x.FoodPhotoLink
            };
            return View(f);
        }

        [HttpGet]
        public IActionResult BeverageGet(int id)
        {
            var x = br.TGetById(id);
            Beverage f = new Beverage()
            {
                BeverageId = x.BeverageId,
                BeverageName = x.BeverageName,
                BeveragePrice = x.BeveragePrice,
                BeveragePhotoLink = x.BeveragePhotoLink
            };
            return View(f);
        }

        [HttpGet]
        public IActionResult VegetableGet(int id)
        {
            var x = vr.TGetById(id);
            Vegetable f = new Vegetable()
            {
                VegetableId = x.VegetableId,
                VegetableName = x.VegetableName,
                VegetablePrice = x.VegetablePrice,
                VegetablePhotoLink = x.VegetablePhotoLink
            };
            return View(f);
        }
        public IActionResult UpdateFood(Food f)
        {
            var x = fr.TGetById(f.FoodId);
            x.FoodName = f.FoodName;
            x.FoodPrice = f.FoodPrice;
            x.FoodPhotoLink = f.FoodPhotoLink;
            fr.TUpdate(x);
            return RedirectToAction("FoodIndex", "Admin"); 
        }
        public IActionResult UpdateVegetable(Vegetable f)
        {
            var x = vr.TGetById(f.VegetableId);
            x.VegetableName = f.VegetableName;
            x.VegetablePrice = f.VegetablePrice;
            x.VegetablePhotoLink = f.VegetablePhotoLink;
            vr.TUpdate(x);
            return RedirectToAction("VegetableIndex", "Admin");
        }
        public IActionResult UpdateBeverage(Beverage f)
        {
            var x = br.TGetById(f.BeverageId);
            x.BeverageName = f.BeverageName;
            x.BeveragePrice = f.BeveragePrice;
            x.BeveragePhotoLink = f.BeveragePhotoLink;
            br.TUpdate(x);
            return RedirectToAction("BeverageIndex", "Admin");
        }
    }
}
