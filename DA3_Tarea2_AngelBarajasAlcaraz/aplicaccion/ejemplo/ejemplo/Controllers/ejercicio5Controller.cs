using ejemplo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemplo.Controllers
{
    public class ejercicio5Controller : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: ejercicio5/getEstados/
        public JsonResult getEstados()
        {
            var estados = db.estados.ToList();
            return Json(estados, JsonRequestBehavior.AllowGet);
        }
        // GET: ejercicio5/getMunicipios/4
        public JsonResult getMunicipios(int id)
        {
            //var municipios = new List<Municipios>();
            //TODO preguntar
            //municipios= db.municipios.Where(a=>a.estadoID.Equals(estadoID)).ToList();
            var estado= db.estados.Include("municipios").Single(a =>a.estadoID==id);
            var muni = estado.municipios;
            return Json(muni, JsonRequestBehavior.AllowGet);
           // var estados = db.municipios.ToList();
        //    return Json(estados, JsonRequestBehavior.AllowGet);
        }
    }
}