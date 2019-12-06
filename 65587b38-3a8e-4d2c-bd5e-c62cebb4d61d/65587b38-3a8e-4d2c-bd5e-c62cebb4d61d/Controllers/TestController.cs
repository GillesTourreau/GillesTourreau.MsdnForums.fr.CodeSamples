using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _65587b38_3a8e_4d2c_bd5e_c62cebb4d61d.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

public ActionResult MonAction()
{
    string maValeur;
    maValeur = this.ControllerContext.HttpContext.Request.Form["maValeur"];

    return View();
}
    }
}
