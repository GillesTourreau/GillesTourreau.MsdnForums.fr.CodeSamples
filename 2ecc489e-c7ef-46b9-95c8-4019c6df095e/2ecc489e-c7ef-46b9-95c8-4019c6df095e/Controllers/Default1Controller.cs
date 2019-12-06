using _2ecc489e_c7ef_46b9_95c8_4019c6df095e.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2ecc489e_c7ef_46b9_95c8_4019c6df095e.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

public ActionResult Index()
{
    MonModèle modèle;
    modèle = new MonModèle();
    modèle.CompteTwitters = ...;
    modèle.Tweets = ...;

    return View(modèle);
}

    }
}
