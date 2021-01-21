using KN2021_SHARING.BussLogic.Master;
using KN2021_SHARING.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KN2021_SHARING.MVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
     
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(mUser data)
        {
            return View();
        }

        public ActionResult CreateJavascript()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateJavascript(mUser data)
        {
            clsMUserBussLogic logic = new clsMUserBussLogic();
            data = logic.InsertData(data);
            return Json(data, string.Empty, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult GetDataUser(int id)
        {
            clsMUserBussLogic logic = new clsMUserBussLogic();
            var data = logic.GetUser(id);
            return Json(data, string.Empty, JsonRequestBehavior.AllowGet);
        }
    }
}