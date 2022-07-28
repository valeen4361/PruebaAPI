using PruebaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaAPI.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ObtenerPersonas() 
        {
                List<Personas> lst;
                using (PruebaApiEntities2 db = new PruebaApiEntities2())
                {
                    lst = (from p in db.Personas
                           select p).ToList();
                }
                return Json(lst , JsonRequestBehavior.AllowGet); //permite solicitud get,
            }
    }
}