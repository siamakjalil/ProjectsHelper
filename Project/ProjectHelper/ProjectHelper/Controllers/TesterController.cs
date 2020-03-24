using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helper;


namespace ProjectHelper.Controllers
{
    public class TesterController : Controller
    {
        // GET: Tester
        public ActionResult Index()
        {
            var test = Notification.SendNotifToOneSignalServer(new NotifModel()
            {
                notification = new NotifBody()
                {
                    body = "حساب کاربری شما تائید ، حالا می تونید به طور کامل از اپ بازار استفاده کنید"
                },
                priority = 10,
                registration_ids = new string[]
                {
                    "e4d8jt8PATo:APA91bGay704TdgUcnFGiZulU-0lfWmr5OHUG37MYoW5EXyJlWwfRXmFBHOEPa2NJ7HDPujWxtHt9A7SKbq_HqIZWBQHGvQeDIIFgFb_sf4peBMSXcY4HYPv1d-6vqMzCSNoGhSJ2LwG"
                }

            }, "https://fcm.googleapis.com/fcm/send",
                "key:AAAAPssKCQw:APA91bEgJNuFPyzoYjrTZh7tzfGtdCpyY04DHBcL-wA2U9ZJthZky92ThJy3W9u24FOpvjC-RJds80QxHdw-AbmOLoEtBHyTfuXqnijULMhjNQrv1S-rc1tHgMNByDDrSaXFHX9Idwko");
            return View();
        }
    }
}