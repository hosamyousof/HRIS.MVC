using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRIS.Web.Controllers
{
    [AllowAnonymous]
    public class CommonController : Controller
    {
        [Route("InvalidDevice")]
        public ActionResult Browser()
        {
            return View();
        }
    }
}