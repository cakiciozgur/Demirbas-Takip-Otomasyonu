using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakipSistemi.Controllers
{   [Authorize(Roles ="Birim Yetkilisi")]
    public class PersonelController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {
            List<Models.tblPersonel> model = new List<Models.tblPersonel>();  
            var Personels = db.tblPersonel.ToList();   
            foreach(var per in Personels)
            {
                if (per.departmanId == Convert.ToInt16(Session["departmanid"]))
                {
                    model.Add(per);
                }
            }
            return View(model);
        }
    }
}