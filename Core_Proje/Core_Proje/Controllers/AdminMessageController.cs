using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_Proje.Controllers
{
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());
        public IActionResult ReceiverMessageList()
        {
            TempData["DeleteUrl"] = "ReceiverMessageList";
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListReceiverMessages(p);
            return View(values);
        }
        public IActionResult SenderMessageList()
        {
            TempData["DeleteUrl"] = "SenderMessageList";
            string p;
            p = "admin@gmail.com";
            var values = writerMessageManager.GetListSenderMessages(p);
            return View(values);
        }
        public IActionResult AdminMessageDetails(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            return View(values);
        }
        public IActionResult AdminMessageDelete(int id)
        {
            var values = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(values);
                return RedirectToAction(TempData["DeleteUrl"].ToString());
            //return RedirectToAction("SenderMessageList");
        }
        [HttpGet]
        public IActionResult AdminMessageSend()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AdminMessageSend(WriterMessage p)
        {
            p.Sender= "admin@gmail.com";
            p.SenderName = "Admin";
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            Context c = new Context();
            var userNameSurname = c.Users.Where(x => x.Email == p.Receiver).Select(y => y.Name + "" + y.Surname).FirstOrDefault();
            p.ReceiverName = userNameSurname;
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
