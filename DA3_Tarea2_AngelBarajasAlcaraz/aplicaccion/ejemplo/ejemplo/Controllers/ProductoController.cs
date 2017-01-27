using ejemplo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejemplo.Controllers
{
    public class ProductoController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: getJsonList
        //TODO es algo
        
        public JsonResult getJsonList()
        {

            var producto = db.producto.ToList();
            return Json(producto, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult crearProducto(Producto producto)
        {
            var respuesta = new { funciono = false };
            try
            {
                db.producto.Add(producto);
                db.SaveChanges();
                 respuesta = new { funciono = true };

            }
            catch 
            {
             
            }
           
            
            return Json(respuesta);
        }
        [HttpGet]
        public JsonResult editarProducto(int id)
        {
            var Pbuscado = db.producto.Find(id);
            var resultado = new { id = Pbuscado.prodictoID, nombre = Pbuscado.nombre, precio = Pbuscado.precio };
            return Json(resultado,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult editarProducto(Producto productoEditado)
        {
            var respuesta = new { funciono = false };

            try
            {
                if (ModelState.IsValid)
                {//unica manera para modificar
                  
                    db.Entry(productoEditado).State = EntityState.Modified;
                    db.SaveChanges();
                    respuesta = new { funciono = true };

                }
            }
            catch
            {
            }
                return Json(respuesta);
        }
        
        [HttpPost]
        public JsonResult eliminarProducto(int id)
        {
            //productoid.Split('a');
            //int id = int.Parse(productoid);
            var Pbuscado = db.producto.Find(id);
            db.producto.Remove(Pbuscado);
            db.SaveChanges();

            var respuesta = new { funciono = false };

            return Json(respuesta);
        }
        public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
                base.OnActionExecuting(filterContext);
            }
        }
    }
}