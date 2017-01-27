using ejemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemplo.Controllers
{
    public class EstadosController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
       
        // GET: Estados
        public JsonResult Index()
        {
            var estados = from este in db.estados select new  { estadoID = este.estadoID, nombre = este.nombre};
            return Json(estados, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Municipios(int id)
        {
            var algo = db.municipios.Where(a => a.estadoID == id);
            var Municipios = from este in algo
                             select new { estadoID = este.municipioID, nombre = este.nombre};

            return Json(Municipios, JsonRequestBehavior.AllowGet);
        }
    }
}