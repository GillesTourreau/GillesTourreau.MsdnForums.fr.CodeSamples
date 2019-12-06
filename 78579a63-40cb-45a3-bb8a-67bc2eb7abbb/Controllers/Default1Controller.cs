using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _78579a63_40cb_45a3_bb8a_67bc2eb7abbb.Controllers
{
    public class Default1Controller : Controller
    {
        //
        // GET: /Default1/

public ActionResult GetCV(int id)
{
    // Rechercher l'inscrit en base
    Inscription inscription;
    inscription = ...;

    return this.File(inscription.cv, "application/pdf", "VotreCV.pdf");
}

    }
}
