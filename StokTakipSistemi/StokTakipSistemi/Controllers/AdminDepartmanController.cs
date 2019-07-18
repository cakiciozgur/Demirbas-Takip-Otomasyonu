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
    public class AdminDepartmanController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {   //Departmanları listeleyerek View'a gönderdik
            var model = db.tblDepartman.ToList();
            return View(model);
        }
        public ActionResult YeniDepartman()
        {
            return View(new tblDepartman());
        }
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(tblDepartman model)
        {
            if (ModelState.IsValid)
            {   //Model validation'ı sağlandığında buraya girecektir.
                db.tblDepartman.Add(model);
                db.SaveChanges();
                var role = new tblRole();
                role.roleAd = "Birim Yetkilisi";
                role.departmanId = model.departmanId;             
                db.tblRole.Add(role);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {  //Model validation'ı sağlanmadığında buraya girecektir.
                return View("YeniDepartman", model);
            }
        }
        public ActionResult Guncelle(int? id)
        {   //Güncellenecek departmanın id'si bu action result'a parametre olarak gönderilir
            if (id <= 0   || id == null  )
            {   //Id hatalı ise sistem bad request hatası döndürecektir 
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                //Id'de herhangi bir hata yok ise  buraya girecektir.

                var model = db.tblDepartman.FirstOrDefault(m => m.departmanId == id);
                if (model == null)
                {    // Elde edilen departman modeli null ise buraya girecektir ve not found hatası verecektir
                    return HttpNotFound();
                }
                else
                {    //Eğer departman modeli null ise güncelleme sayfasını bu model geri döndürülecektir
                    return View(model);
                }

            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Guncelle(tblDepartman model)
        {  
            if (model.departmanId > 0)
            {   if (ModelState.IsValid)
                {  //Güncellenecek model gerekli validationları geçerse buraya girecektir.
                    var eskidepartman = db.tblDepartman.FirstOrDefault(m => m.departmanId == model.departmanId);
                    if (eskidepartman != null)
                    {  // Güncelle işleminin yapıldığı yerdir.
                        eskidepartman.departmanAd = model.departmanAd;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                    else
                    {  // Güncellenecek model bulunamadıysa not found hatası verilecektirç
                        return HttpNotFound();
                    }

                }
                else
                {
                    return View("Guncelle", model);
                }
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
        }

    }
}