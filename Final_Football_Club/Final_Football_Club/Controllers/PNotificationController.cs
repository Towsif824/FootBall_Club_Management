using Final_Football_Club.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Football_Club.Controllers
{
    public class PNotificationController : Controller
    {
        ClubEntities2 noti = new ClubEntities2();
        // GET: PNotification
        public ActionResult Index()
        {
            var data = Session["UserName"];
            return View(noti.PNotifications.Where(x => x.UserName == data).OrderByDescending(x => x.Date).ToList());
        }
    }
}