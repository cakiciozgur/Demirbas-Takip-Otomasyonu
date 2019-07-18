using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StokTakipSistemi.Models;
namespace StokTakipSistemi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminStokController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {
            var model = db.tblStok.ToList();
            return View(model);
        }
        public ActionResult UrunAl()
        {
            var model = new ViewModels.UrunParca();
            model.ParcaTipleri = db.tblParcaTipi.ToList();
            return View(model);
        }
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(ViewModels.UrunParca model)
        {
            // burada genel ürünü dbye ekliyoruz,stok'a ekliyoruz ve adet sayısı kadar ürün oluşturuyoruz.
            if (ModelState.IsValid)
            {     // burada genel ürünü dbye ekliyoruz,stok'a ekliyoruz ve adet sayısı kadar ürün oluşturuyoruz.

                model.Urun.urunSatinAlmaTarih = DateTime.Now;
                model.Urun.urunToplamFİyat = model.Urun.urunFiyat * model.Urun.urunAdet;
                model.Urun.Aktiflik = true;

                db.tblUrunGenel.Add(model.Urun);
                db.SaveChanges();

                tblUrun urun = new tblUrun();
                urun.urunAd = model.Urun.urunAd;
                urun.urunSatinAlmaTarih = model.Urun.urunSatinAlmaTarih;
                urun.urunFiyat = model.Urun.urunFiyat;
                urun.urunGenelId = model.Urun.urunGenelId;
                urun.satinAlinanKurum = model.Urun.satinAlinanKurum;
                urun.urunParcaId = model.Urun.urunParcaId;
                urun.Aktiflik = true;

                for (int i = 0; i < model.Urun.urunAdet; i++)
                {
                    db.tblUrun.Add(urun);
                    db.SaveChanges();
                }

                tblStok stok = new tblStok();
                stok.urunGenelId = model.Urun.urunGenelId;
                db.tblStok.Add(stok);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                model.ParcaTipleri = db.tblParcaTipi.ToList();
                return View("UrunAl", model);
            }

        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            if (id > 0)
            { // id hatasız ise buraya girecektir.
                ViewModels.UrunParca model = new ViewModels.UrunParca();
                var genelurun = db.tblUrunGenel.FirstOrDefault(m => m.urunGenelId == id);
                if (genelurun != null)
                {  // güncellenecek model bulunduysa sistem buraya girecektir
                    model.Urun = genelurun;
                    model.ParcaTipleri = db.tblParcaTipi.ToList();
                    return View(model);
                }
                else
                {  // güncellenecek model bulunmadıysa sistem buraya girecektir
                    return HttpNotFound();
                }

            }
            else
            {  // id hatalı ise sistem bad request hatası verecektir.
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guncelle(ViewModels.UrunParca model)
        {
            if (ModelState.IsValid)
            {  
                if (model.Urun.urunGenelId>0)
                {
                    var eskigenelurun = db.tblUrunGenel.FirstOrDefault(m => m.urunGenelId == model.Urun.urunGenelId);
                    if (eskigenelurun != null)
                    {    //model validationları sağladığı takdirde buraya girecektir
                        //güncelleme işlemi bu if bloğunda gerçekleşmektedir
                        foreach (var urun in eskigenelurun.tblUrun.ToList())
                        {
                            if (urun.zimmetDurumu == null && urun.zimmetDurumu == null)
                            {
                                db.tblUrun.Remove(urun);
                                db.SaveChanges();
                            }
                        }
                        eskigenelurun.urunAd = model.Urun.urunAd;
                        eskigenelurun.urunAdet = model.Urun.urunAdet;
                        eskigenelurun.urunFiyat = model.Urun.urunFiyat;
                        eskigenelurun.urunParcaId = model.Urun.urunParcaId;
                        eskigenelurun.satinAlinanKurum = model.Urun.satinAlinanKurum;
                        eskigenelurun.urunToplamFİyat = model.Urun.urunFiyat * model.Urun.urunAdet;
                        db.SaveChanges();


                        var urn = new Models.tblUrun();
                        urn.urunAd = model.Urun.urunAd;
                        urn.urunFiyat = model.Urun.urunFiyat;
                        urn.urunParcaId = model.Urun.urunParcaId;
                        urn.urunGenelId = model.Urun.urunGenelId;
                        urn.satinAlinanKurum = model.Urun.satinAlinanKurum;
                        urn.Aktiflik = true;
                        urn.urunSatinAlmaTarih = DateTime.Now;

                        for (int i = 0; i < model.Urun.urunAdet; i++)
                        {
                            db.tblUrun.Add(urn);
                            db.SaveChanges();
                        }
                        return RedirectToAction("Index");
                        
                    }
                    else
                    {   // eski güncellenecek ürün bulunmdıysa not found hataso verecektir
                        return HttpNotFound();
                    }
                    

                }
                else
                {   // ürün id'si hatalı ise sistem badrequest hatası verecektir.
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                
            }
            else
            {  //model validationları sağlamıyorsa geri döndürülmektedir.
                model.ParcaTipleri = db.tblParcaTipi.ToList();
                return View("Guncelle", model);
            }


        }
       
        [HttpGet]
        public ActionResult Zimmetle(int id)
        {   
            if (id > 0)
            {  
                var model = new ViewModels.UrunDepartman();
                model.Departmanlar = db.tblDepartman.ToList();
                model.Urun = db.tblUrunGenel.FirstOrDefault(m => m.urunGenelId == id);
                if (model.Urun != null)
                {
                    return View(model);
                }
                else
                {
                    //model bulunamadıysa not found hatası döndürülecektir
                    return HttpNotFound();
                }
            }
            else
            {   // gönderilen id hatalı iste bad request hatası döndürülecektir
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Zimmetle(ViewModels.UrunDepartman model, int persid)
        {
            if (persid > 0)
            {
                var personel = db.tblPersonel.FirstOrDefault(m => m.personelId == persid);
                if (personel != null)
                {
                    if (ModelState.IsValid)
                    {
                        if (model.Urun.urunGenelId > 0)
                        {
                            var GenelUrun = db.tblUrunGenel.FirstOrDefault(m => m.urunGenelId == model.Urun.urunGenelId);

                            if (GenelUrun != null && GenelUrun.Aktiflik == true)
                            {  // model tüm validationları sağladığında buraya düşecek işlem gerçekleşecektir
                                GenelUrun.urunAdet--;
                                GenelUrun.urunToplamFİyat = GenelUrun.urunFiyat * GenelUrun.urunAdet;
                                db.SaveChanges();

                                if (GenelUrun.urunAdet == 0)
                                {   // urun adeti 0 lanmış ise stoktan düşme işleminin gerçekleştirildiği blok tur.
                                    var stok = db.tblStok.FirstOrDefault(m => m.urunGenelId == GenelUrun.urunGenelId);
                                    db.tblStok.Remove(stok);
                                    db.SaveChanges();
                                }

                                var Zimmet = new tblZimmet();
                                foreach (var urun in GenelUrun.tblUrun)
                                {
                                    if (urun.zimmetDurumu == null)
                                    {
                                        urun.zimmetDurumu = true;
                                        Zimmet.urunId = urun.urunId;
                                        break;
                                    }
                                }
                                Zimmet.personelId = personel.personelId;
                                db.tblZimmet.Add(Zimmet);
                                db.SaveChanges();
                                return RedirectToAction("Index");
                            }
                            else
                            {
                                return HttpNotFound();
                            }
                        }
                        else
                        {
                            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                        }
                    }
                    else
                    {
                        model.Departmanlar = db.tblDepartman.ToList();
                        return View("Zimmetle", model);
                    }
                 }
                else
                {  //personel bulunamadıysa sistem not found hatası verecektir
                    return HttpNotFound();
                }
            }
            else
            {  // id hatalı ise sistem bad request hatası döndürecektir
                return new  HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

        }
        public ActionResult GetPersonels(int id)
        {    // metot gönderilen id'ye göre Personelleri Json formatında döndürmektedir
            if (id > 0)
            { 
                db.Configuration.ProxyCreationEnabled = false;
                var model = new List<Models.tblPersonel>();
                foreach (var personel in db.tblPersonel.ToList())
                {
                    if (personel.departmanId == id)
                        model.Add(personel);
                }
                return Json(model, JsonRequestBehavior.AllowGet);
            }
            else
            {  // id hatalı iste sistem bad request hatası verecektir
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


        }



       
        
    }

}
