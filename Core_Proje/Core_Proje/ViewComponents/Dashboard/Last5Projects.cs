using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {
        Context c = new Context();
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Skills.Count();
            ViewBag.v2 = c.Messages.Where(x => x.Status == false).Count();
            ViewBag.v3 = c.Messages.Where(x => x.Status == true).Count();
            ViewBag.v4 = c.Experiances.Count();
            var values = featureManager.TGetList();
            return View(values);
        }
    }
}
