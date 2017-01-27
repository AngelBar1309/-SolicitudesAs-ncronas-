using ejemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemplo.Controllers
{
    public class ComputadorasController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Computadoras
        public JsonResult Index()
        {
            return Json(db.modelos.ToList(),JsonRequestBehavior.AllowGet);
        }
    }
}