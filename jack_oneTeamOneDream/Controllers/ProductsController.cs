using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using jack_oneTeamOneDreamDatabase;
using jack_oneTeamOneDreamEntities;
using jack_oneTeamOneDreamLogic;

namespace jack_oneTeamOneDream.Controllers
{
    public class ProductsController : Controller
    {
        private OneTeamOneDreamLogic logicService = new OneTeamOneDreamLogic();

        // GET: Products
        public ActionResult Index()
        {
            return View(logicService.getAllProducts());
        }

        // GET: Products/Details/5
        public ActionResult Details(int? id)
       {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = logicService.getProductById(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
       }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                logicService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
