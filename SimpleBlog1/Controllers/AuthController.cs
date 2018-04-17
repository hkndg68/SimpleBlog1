using SimpleBlog1.ViewModels;
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
        public ActionResult Login()
        {
            return View(new Authlogin() {Test="This my test value set in my controller"}
                );   
            
        }
        [HttpPost]
        public ActionResult Login(Authlogin form)
     
        {
            if (!ModelState.IsValid)
        {
            return View(form);
        }
    if (form.UserName!="hakan")
    {
        ModelState.AddModelError("Username", "Hatalı");
        return View(form);
    }

            return Content("the form is valid");
        }
	}
}