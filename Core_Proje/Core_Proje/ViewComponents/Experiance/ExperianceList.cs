using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Experiance
{
    public class ExperianceList: ViewComponent
    {
        ExperianceManager experianceManager = new ExperianceManager(new EfExperianceDal());
        public IViewComponentResult Invoke()
        {
            var values = experianceManager.TGetList();
            return View(values);
        }
    }
}
