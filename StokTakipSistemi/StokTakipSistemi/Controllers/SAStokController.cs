using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StokTakipSistemi.Models;
using StokTakipSistemi.ViewModels;

namespace StokTakipSistemi.Controllers
{   [Authorize(Roles="Satın Alma")]
    public class SAStokController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {  // tüm ürünler listelenip view'a gönderilir
            var model = db.tblStok.ToList();
            return View(model);
        }

        public ActionResult YeniUrun()
        {
            var model = new UrunParca();
            model.ParcaTipleri = db.tblParcaTipi.ToList();
            return View(model);
        }
        [ValidateAntiForgeryToken]
        public ActionResult SatinAl(UrunParca model)
        {
            model.Urun.urunSatinAlmaTarih = DateTime.Now;

            if (ModelState.IsValid)
             {  //burada genel ürünü dbye ekliyoruz,stok'a ekliyoruz ve adet sayısı kadar ürün oluşturuyoruz.
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
             {  // model validationları sağlamıyor ise burası çalışacak ve view'a bu model tekrar dönecektir
                model.ParcaTipleri = db.tblParcaTipi.ToList();
                 return View("YeniUrun", model);
             }
            
        }
       
        public ActionResult Zimmet(int id)
        {   
            if (id > 0)
            {
                if (id != 1)
                {
                    var model = new UrunDepartman();
                    var Genelurun = db.tblUrunGenel.FirstOrDefault(m => m.urunGenelId == id);
                    if (Genelurun != null)
                    {
                        model.Urun = Genelurun;
                        model.Departmanlar = db.tblDepartman.ToList();
                        return View(model);
                    }
                    else
                    { // if model null ise not found hatası döndülecektir
                        return HttpNotFound();
                    }
                }
                else
                {  // id hatalı ise (id=1)  sistem bad request hatası döndürecektir
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                
            }
            else
            {   // id hatalı is(id<0) sistem bad request hatası döndürecektir
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }
        public ActionResult GetPersonels(int id)
        {  // gönderilen id'ye göre personnellerin Json formatında listelendiği Metotdur.
            if (id > 0)
            {
                db.Configuration.ProxyCreationEnabled = false;
                List<tblPersonel> personels = new List<tblPersonel>();
                var model = db.tblPersonel.ToList();
                foreach (var personel in model)
                {
                    if (personel.departmanId == id)
                        personels.Add(personel);
                }
                return Json(personels, JsonRequestBehavior.AllowGet);
            }
            else
            {  // id hatalı ise sistem bad request hatası döndürecektir
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

        }

        [ValidateAntiForgeryToken]
        public ActionResult ZimmetTamamla(UrunDepartman model,int persid)
        {
             if (persid > 0)// personel id uygun is(0 dan büyük)
             {
                if (model.Urun.urunSatinAlmaTarih !=null)
                {
                    if (ModelState.IsValid)// Model tam olarak buraya gönderilmiş ise
                    {
                        if (model.Urun.urunGenelId > 0) //Modelin id si değiştirilmemiş ise
                        {
                            var GenelUrun = db.tblUrunGenel.FirstOrDefault(m => m.urunGenelId == model.Urun.urunGenelId);
                            if (GenelUrun != null && GenelUrun.Aktiflik == true)
                            {
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
                                var personel = db.tblPersonel.FirstOrDefault(m => m.personelId == persid);
                                Zimmet.personelId = personel.personelId;

                                db.tblZimmet.Add(Zimmet);
                                db.SaveChanges();
                                return RedirectToAction("Index");

                            }
                            else
                            {     // böyle bir model yok
                                return HttpNotFound();
                            }
                        }
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }
                    else
                    {// model validation ları sağlamıyor ise view'a tekrar döndürülür
                        model.Departmanlar = db.tblDepartman.ToList();
                        return View("Zimmet", model);
                    }
                }else
                { // model'in satın alma tarihi validationu sağlanmıyorsa bir mesaj view'A iletilir
                    ViewBag.Mesaj = "Ürün Satın Alma Tarihi Boş Olamaz";
                    model.Departmanlar = db.tblDepartman.ToList();
                    return View("Zimmet",model);
                }
                
             }
             else
             {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
             }
        }

    }
}