using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class AdminNavbarMessageList : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        private readonly UserManager<WriterUser> _userManager;

        public IViewComponentResult Invoke()
        { 
            //var context = new Context();


            //var result = from c in context.WriterMessage
            //             join o in context.Users
            //             on c.Sender equals o.Email
            //             select new
            //             {
            //                 c.WriterMessageID,
            //                 c.SenderName,
            //                 c.Date
            //             };
            string p = "admin@gmail.com";

            var values = writerMessageManager.GetListReceiverMessages(p)
                .OrderByDescending(x => x.WriterMessageID).ToList();

            return View(values);
        }
    }
}
