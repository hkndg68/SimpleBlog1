using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog1.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/
        public ActionResult login()
        {
            return Content("Auth controller login action");
        }
	}
}