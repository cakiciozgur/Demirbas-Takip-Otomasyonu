using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StokTakipSistemi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminRaporController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {   //Personel ve departmanlar listelelenerek model şeklinde view'a aktarılmaktadır.
            var model = new ViewModels.PersonellerDepartmanlar();
            model.Departmalar = db.tblDepartman.ToList();
            model.Personeller = db.tblPersonel.ToList();
            return View(model);
        }

        public JsonResult GetProductforPer(int id)
        {  
            // bu metotda gönderilen id'ye göre ürünleri json formatında  getirme işlemi yapılmaktadır
            db.Configuration.ProxyCreationEnabled = false;
            List<ViewModels.UrunlerParca> UrunsParcas = new List<ViewModels.UrunlerParca>();
           
            foreach (var zim in db.tblZimmet.ToList())
            {
                if (zim.personelId == id)
                {
                    ViewModels.UrunlerParca urunparca = new ViewModels.UrunlerParca();
                    var urun = db.tblUrun.FirstOrDefault(m => m.urunId == zim.urunId);
                    var parca = db.tblParcaTipi.FirstOrDefault(m => m.urunParcaId == urun.urunParcaId);

                    urunparca.Urun = urun;
                    urunparca.Parca = parca.parcaTipi;
                    UrunsParcas.Add(urunparca);
                    urun.tblAtikKontrol.Clear();
                    urun.tblZimmet.Clear();
                }
            }
            
            return Json(UrunsParcas, JsonRequestBehavior.AllowGet);
            

        }

        public JsonResult GetProductforDep(int id)
        {
              // Bu metotda gönderilen departman id'sine göre ürünlerin bir model halinde json formatında döndürülmesi işlemi yapılmaktadır
            db.Configuration.ProxyCreationEnabled = false;
            var Personels = db.tblPersonel.ToList();
            var UrunsParca = new List<ViewModels.UrunlerParca>();
            foreach(var per in Personels)
            {
                if (per.departmanId == id)
                { 
                    foreach(var zimmet in db.tblZimmet.ToList())
                    {
                        if (zimmet.personelId ==per.personelId)
                        {
                            var urunparca = new ViewModels.UrunlerParca();
                            urunparca.Urun = db.tblUrun.FirstOrDefault(m => m.urunId == zimmet.urunId);

                            var urungenel = db.tblUrunGenel.FirstOrDefault(m => m.urunGenelId == urunparca.Urun.urunGenelId);
                            var parca = db.tblParcaTipi.FirstOrDefault(m => m.urunParcaId == urungenel.urunParcaId);
                            urunparca.Parca = parca.parcaTipi;
                            UrunsParca.Add(urunparca);

                            urunparca.Urun.tblAtikKontrol.Clear();
                            urunparca.Urun.tblZimmet.Clear();
                            urungenel.tblStok.Clear();
                            urungenel.tblUrun.Clear();
                            parca.tblUrunGenel.Clear();

                        }
                    }
                    
                }
                
            }

            return Json(UrunsParca, JsonRequestBehavior.AllowGet);


        }

    }
}