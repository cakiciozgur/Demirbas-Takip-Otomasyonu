using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakipSistemi.Controllers
{  [Authorize(Roles ="Birim Yetkilisi,Admin,Satın Alma")]
    public class AtıkDepoController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {
            var model = db.tblAtikKontrol.ToList();
            return View(model);
        }
    }
}