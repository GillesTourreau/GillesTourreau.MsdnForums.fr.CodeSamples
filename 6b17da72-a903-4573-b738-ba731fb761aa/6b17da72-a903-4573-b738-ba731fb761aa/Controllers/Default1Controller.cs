using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _6b17da72_a903_4573_b738_ba731fb761aa.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

public ActionResult Index()
{
    int id = 1664;

    return View(id);
}

    }
}
