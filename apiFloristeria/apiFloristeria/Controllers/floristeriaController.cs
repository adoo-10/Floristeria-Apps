using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace apiFloristeria.Controllers
{
    public class floristeriaController : ApiController
    {
        [System.Web.Http.HttpPost]
        public IHttpActionResult Add(Models.Request.floristeriaRequest model)
        {
            using (Models.FloristeriaParcialEntities1 db = new Models.FloristeriaParcialEntities1())

            {
                var flor = new Models.Flores();
                flor.nombreFlor = model.nombreFlor;
                flor.cantidad = model.Cantidad;
                flor.precio = model.Precio;
                flor.estado = model.Estado;
                db.Flores.Add(flor);
                db.SaveChanges();

            }
            return Ok("Hecho");
        }
    }
}