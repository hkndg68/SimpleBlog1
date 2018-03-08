using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog1.Areas.admin.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /admin/Orders/
        public ActionResult Index()
        {
            return Content("Order Index");
        }
        public ActionResult List()
        {
            return Content("Order List");
        }
	}
     
}