using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace StokTakipSistemi.Controllers
{
    [Authorize(Roles = "Satın Alma")]
    public class SAPersonelController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {  // tüm personeller listelenerek model halinde view'a gönderilmektedir.
            var model = db.tblPersonel.ToList();
            return View(model);
        }
        public ActionResult Urunler(int personelid)
        {
            if (personelid > 0)
            {
                var model = db.tblPersonel.FirstOrDefault(m => m.personelId == personelid);
                if (model != null)
                {   var urunler = new List<Models.tblUrun>();
                    var Zimmetler = model.tblZimmet;
                    foreach (var zimmet in model.tblZimmet)
                    {
                        var urun = db.tblUrun.First(x => x.urunId == zimmet.urunId);
                        urunler.Add(urun);
                    }
                    return View(urunler);
                }
                else
                {   // model bulunamadıysa notfound hatası döndürülmektedir
                    return HttpNotFound();
                }
            }
            else
            {
                // personelid hatalı ise sistem bad request döndürmektedir.
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

        }
        
        public ActionResult ZimmetKaldir(int id)
        {
            //buraya gelen id ürünnün id sidir burada zimmetden düşülüp atık tablosuna eklenir
            if (id > 0)
            {   // id 0 dan büyük ise bu if bloğu aktif olacaktır
                var atik = new Models.tblAtikKontrol();
                var urun = db.tblUrun.FirstOrDefault(m => m.urunId == id);
                if (urun != null)
                {
                    var zimmet = db.tblZimmet.FirstOrDefault(m => m.urunId == id);
                    if (zimmet != null)
                    {  // zimmet null değilse burası çalışacaktır
                        urun.zimmetDurumu = false;
                        urun.Aktiflik = false;

                        bool test = false;
                        foreach (var atIk in db.tblAtikKontrol.ToList())
                        {
                            if (atIk.tblUrun.urunGenelId == urun.urunGenelId)
                                test = true;
                        }

                        if (!test)
                        {
                            atik.urunId = urun.urunId;
                            atik.atikurunAdet = 1;
                            db.tblAtikKontrol.Add(atik);
                            db.SaveChanges();
                        }
                        else
                        {
                            foreach (var Atik in db.tblAtikKontrol.ToList())
                            {
                                if (Atik.tblUrun.urunGenelId == urun.urunGenelId)
                                {
                                    Atik.atikurunAdet++;
                                    db.SaveChanges();
                                }
                            }
                        }
                        db.tblZimmet.Remove(zimmet);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {  // sistem zimmet bulunamadığı için not found döndürecektir.
                        return HttpNotFound();
                    }

                }
                else
                {
                    //sistem model bulunamadığından dolayı not found hatası döndürecektir.
                    return HttpNotFound();
                }

            }
            else
            {  // id hatalı ise sistem badrequest döndürecektir.
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

        }
    }
}