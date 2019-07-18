using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StokTakipSistemi.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminPersonelController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {
            //personel listesi view'a eklenir
            var model = db.tblPersonel.ToList();
            return View(model);
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            if (id > 0)
            {   
                var model = new ViewModels.PersonelDepartman();
                model.Departmanlar = db.tblDepartman.ToList();
                model.Personel = db.tblPersonel.FirstOrDefault(m => m.personelId == id);
                if (model.Personel != null)
                {  // model null değil ise güncellenmek üzere View'a gönderilir 
                    return View(model);
                }
                else
                {//model null ise Not Found hatası alınır
                    return HttpNotFound();
                }
            }
            else
            {  // Zararlı bir id girildiğinzde badrequest isteği döndürülür
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guncelle(ViewModels.PersonelDepartman model)
        {
            if (ModelState.IsValid)
            {   
                if (model.Personel.personelId > 0)
                {
                    if (model.Personel.Aktiflik!=false)
                    {   //personel aktifliği kontrol edilmektedir.
                        var eskiPersonel = db.tblPersonel.FirstOrDefault(m => m.personelId == model.Personel.personelId);
                        if (eskiPersonel != null)
                        {  //Güncellenecek model tüm validationları sağlıyor ise buraya girecek ve güncellenecektir.
                            eskiPersonel.personelAd = model.Personel.personelAd;
                            eskiPersonel.personelSoyad = model.Personel.personelSoyad;
                            eskiPersonel.Aktiflik = model.Personel.Aktiflik;
                            eskiPersonel.departmanId = model.Personel.departmanId;
                            db.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {   // güncellenecek model null ise Not Found Hatası Verilecektir
                            return HttpNotFound();
                        }
                    }
                    else
                    {    //Personel aktifliği false ise bad request dönecektir
                        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                    }
                    
                }
                else
                {    //personelin id 0 dan az ise bad request dönecektir. 
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
               
            }
            else
            {   // model gerekli validationları sağlamıyor ise tekrar güncelleme sayfasına iletilmektedir.
                model.Departmanlar = db.tblDepartman.ToList();
                return View("Guncelle", model);
            }
            
        }

        public ActionResult Urunler(int personelid)
        {   
            if (personelid != 0)
            {   
                var personel = db.tblPersonel.FirstOrDefault(m => m.personelId == personelid);
                if (personel != null)
                {  // Personel'in veritabanında olup olmadığı kontrol edilmektedir
                    var zimmets = db.tblZimmet.ToList();
                    var Uruns = new List<Models.tblUrun>();
                    foreach (var zimmet in zimmets)
                    {
                        if (zimmet.personelId == personelid)
                        {
                            var urun = new Models.tblUrun();
                            urun = zimmet.tblUrun;
                            Uruns.Add(urun);
                        }
                    }
                    if (Uruns.Count > 0)
                    {
                        return View(Uruns);
                    }
                    else
                    {
                        return HttpNotFound();
                    }

                }
                else
                { //Personel yoksa Not Found Hatası vermektedir.
                    return HttpNotFound();
                }
            }
            else
            {   // gönderilen id hatalı ise sistem bad request hatası verecektir.
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
          }
        
        public ActionResult ZimmetKaldir(int id)
        {
            if (id > 0)
            {
                var urun = db.tblUrun.FirstOrDefault(m => m.urunId == id);
                if (urun != null)
                {
                    var zimmet = db.tblZimmet.FirstOrDefault(m => m.tblUrun.urunId == id);
                    if (zimmet != null)
                    {
                        db.tblZimmet.Remove(zimmet);
                        db.SaveChanges();
                        // zimmeti kaldırdık şimdi ürünü atık tablosuna ekleyeceğiz

                        var atik = db.tblAtikKontrol.FirstOrDefault(m => m.tblUrun.urunGenelId == urun.urunGenelId);
                        if (atik != null)
                        {       // bu ürüne ait atık kaydı varsa adeti arttırılacaktır
                                urun.zimmetDurumu = false;
                                urun.Aktiflik = false;
                                atik.atikurunAdet++;
                                db.SaveChanges();
                        }
                        else
                        {  // ürün'e ait atık kaydı yoksa atık oluşturulup atık tablosuna bu ürün atılmaktadır.
                            urun.zimmetDurumu = false;
                            urun.Aktiflik = false;
                            db.SaveChanges();
                            var Atik = new Models.tblAtikKontrol();
                            Atik.urunId = urun.urunId;
                            Atik.atikurunAdet = 1;
                            db.tblAtikKontrol.Add(Atik);
                            db.SaveChanges();
                        }
                        return RedirectToAction("Index");

                    }
                    else
                    {   //personel bulunamadıysa(personel id)  Not Found hatası verecektir
                        return HttpNotFound();
                    }
                        
                }
                else
                {  //Ürün yok sistem Not Found Hatası verecektir.
                    return HttpNotFound();
                }

            }

            else
            {   //Personel id'si hatalı gönderildiğin sistem bad request hatası vermektedir.
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
        }
    }
}