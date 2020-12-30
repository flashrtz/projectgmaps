using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectgmaps.Models;

namespace projectgmaps.Controllers
{
    [Controller]
    public class RegistrationController : Controller
    {
        private readonly ApplicationUser _auc;
        

        public RegistrationController(ApplicationUser auc)
        {
            _auc = auc;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The user " + uc.Username + " is saved successfully";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateBuyer(UserBuyer uc)
        {
            _auc.Add(uc);
            _auc.SaveChanges();
            ViewBag.message = "The user is saved successfully";
            return View();
        }

        public JsonResult GetAllLocation()
        {
            //_auc.Add(uc);
            var x = _auc.FarmerLocation.ToList();
            return Json(x);
            

            //_auc.SaveChanges();
            //ViewBag.message = "The user " + uc.Username + " is saved successfully";
        //   return View();
        }


       

    }
}