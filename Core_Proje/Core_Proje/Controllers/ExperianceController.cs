using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ExperianceController : Controller
    {
        ExperianceManager experianceManager = new ExperianceManager(new EfExperianceDal());
        public IActionResult Index()
        {
            var values = experianceManager.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddExperiance()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperiance(Experiance experiance)
        {
            experianceManager.TAdd(experiance);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperiance(int id)
        {
            var values = experianceManager.TGetByID(id);
            experianceManager.TDelete(values);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult EditExperiance(int id)
        {
            var values = experianceManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditExperiance(Experiance experiance)
        {
            experianceManager.TUpdate(experiance);
            return RedirectToAction("index");
        }
    }
}
