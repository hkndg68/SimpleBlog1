using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog1.Areas.admin.Controllers
{
    public class loginController : Controller
    {
        //
        // GET: /admin/Login/
        public ActionResult login()
        {
            return View();
        }
	}
}