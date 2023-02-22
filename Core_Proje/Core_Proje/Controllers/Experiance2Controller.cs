using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class Experiance2Controller : Controller
    {
        ExperianceManager experianceManager = new ExperianceManager(new EfExperianceDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListExperiance()
        {
            var values = JsonConvert.SerializeObject(experianceManager.TGetList());
            return Json(values);
        }
        [HttpPost]
        public IActionResult AddExperiance(Experiance p)
        {
            experianceManager.TAdd(p);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
        public IActionResult GetById(int ExprerienceID)
        {
            var v = experianceManager.TGetByID(ExprerienceID);
            var values = JsonConvert.SerializeObject(v);
            return Json(values);
        }
        public IActionResult DeleteExperiance(int id)
        {
            var v = experianceManager.TGetByID(id);
            experianceManager.TDelete(v);
            return NoContent();
        }
        public IActionResult UpdateExperince(Experiance p)
        {
            var v = experianceManager.TGetByID(p.ExperianceID);
            experianceManager.TUpdate(v);
            var values = JsonConvert.SerializeObject(p);
            return Json(values);
        }
    }
}
