using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace StokTakipSistemi.Controllers
{   [Authorize(Roles ="Admin")]
    public class AdminKullanicilarController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        public ActionResult Index()
        {   //tüm kullanıcılar listelenerek index view'ına gönderilir
            var model = db.tblKullanıcı.ToList();
            return View(model);
        }
          public ActionResult YeniKullanici()
         {   //Yeni kullanıcı eklemek için kullanılan bu action result'da view'a boş bir kullanıcırole ModelView gönderilir
             return View(new ViewModels.KullaniciRole() {Kullanici=null,Roller=db.tblRole.ToList()});
         }
        [ValidateAntiForgeryToken]
         public ActionResult Ekle(ViewModels.KullaniciRole model,int roleid)
         {
              
             if (ModelState.IsValid)
             {
                if (roleid > 0)
                {
                    var yetki = db.tblRole.FirstOrDefault(m => m.roleId == roleid);
                    if (yetki != null)
                    {
                        var testmodel = db.tblKullanıcı.FirstOrDefault(m => m.username == model.Kullanici.username);
                        if (testmodel == null)
                        {  // Eklenmek istenen kullanıcı model'inin adı kullanılmamış ise buraya girecektir
                            var lasttestmodel = db.tblKullanıcı.FirstOrDefault(m => m.email == model.Kullanici.email);
                            if (lasttestmodel == null)
                            {    
                                //Eklenecek Kullanıcı modeli tüm validationları sağlarsa buraya gelecek ve ekleme işlemi gerçekleşecektir
                                string temppas = ""; 
                                temppas=Encrypt(model.Kullanici.password);
                                model.Kullanici.password = temppas;
                                model.Kullanici.roleId = roleid;
                                model.Kullanici.sonGirisTarihi = DateTime.Now;
                                db.tblKullanıcı.Add(model.Kullanici);
                                db.SaveChanges();
                                return RedirectToAction("Index");
                            }
                            else
                            {  
                                //Kayıtlı bir e-mail kullandığı takdirde buraya girecektir.
                                ViewBag.Data = "Bu E-mail'e Kayıtlı Başka Bir Kullanıcı Bulunmaktadır";
                                model.Roller = db.tblRole.ToList();
                                return View("YeniKullanici", model);

                            }

                        }
                        else
                        {
                            //Girilen kullanıcı adında başka bir kullanıcı varsa buraya girecektir
                            ViewBag.Data = "Bu Kullanıcı Adı ile Başka Bir Kullanıcı Bulunmaktadır";
                            model.Roller = db.tblRole.ToList();
                            return View("YeniKullanici", model);

                        }
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
                 model.Roller = db.tblRole.ToList();
                 return View("YeniKullanici", model);
             }

         }
        private string Encrypt(string clearText)
        {  //Gönderilen şifrenin kodlanması yani şifrelenmesi için bu metod kullanılır
            //Kodlanan şifre geri döndürülür
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }

    }
}