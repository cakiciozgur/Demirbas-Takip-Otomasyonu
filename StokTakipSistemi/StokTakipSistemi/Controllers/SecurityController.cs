using StokTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace StokTakipSistemi.Controllers
{
    public class SecurityController : Controller
    {
        StokTakipSistemiDBEntities db = new StokTakipSistemiDBEntities();
        [HttpGet]
        public ActionResult Login()
        { //Giriş ekranının açıldığı HttpGet action result'ıdır.
            return View(new ViewModels.KullaniciLoginView());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(ViewModels.KullaniciLoginView model)
        {
             model.password = Encrypt(model.password);
           
            if (ModelState.IsValid)
            {     
                  var kullanici = db.tblKullanıcı.FirstOrDefault(m => m.username == model.username && m.password == model.password);
                  if (kullanici!=null)
                  {  // kullanının kullanıcı adı ve şifresi doğrulanmışsa bu if'e girecektir
                     kullanici.sonGirisTarihi = DateTime.Now;
                     db.SaveChanges();// save hatası
                        if (kullanici.tblRole.roleAd == "Admin")
                        {  // kullanıcı admin ise bu bloğa girerek authorization ayarı yapılırak giriş aktif edilir

                            FormsAuthentication.SetAuthCookie(kullanici.username, false);
                            return RedirectToAction("Index", "AdminStok");//admin 
                        }
                        else if (kullanici.tblRole.roleAd == "Satın Alma")
                        {  // kullanıcı satın alma yetkilisi ise bu bloğa girerek giriş işlemleri tamamlanır

                            FormsAuthentication.SetAuthCookie(kullanici.username, false);
                            Session["username"] = kullanici.username;
                            return RedirectToAction("Index", "SAStok");// satın alma yetkilisi
                        }
                        else
                        {  // kullanıcı birim yetkilisi ise bu bloğa girerek giriş işlemleri tamamlanır
                            FormsAuthentication.SetAuthCookie(kullanici.username, false);
                            Session["username"] = kullanici.username;
                            Session["departmanid"] = kullanici.tblRole.departmanId;
                            Session["Departman"] = kullanici.tblRole.tblDepartman.departmanAd;
                            return RedirectToAction("Index", "Stok");// birim yetkilisi

                        }
                    
                    
                  }
                  else
                  {  // model gerekli validationları sağlamıyorsa buraya girer ve mesaj yazdırır.
                       ViewBag.Mesaj = "Kullanıcı Adı veya Şifre Hatalı veya Eksik!";
                       return View("Login", model);
                  }
            }
            else
            {
                ViewBag.Mesaj = "Kullanıcı Adı veya Şifre Hatalı veya Eksik!";
                return View("Login", model);
            }
        }

        public ActionResult Logout()
        {  // session lar null yapılarak çıkış işlemi yapılmaktadır
            Session["username"] = null;
            Session["departmanid"] = null;
            Session["Departman"] = null;

            FormsAuthentication.SignOut();
            return RedirectToAction("Login");

        }
        private string Encrypt(string clearText)
        {  // kullanıcı şifresinin kodlanarak şifrelendiği metotdur.
            // şifreyi kodlanmış  şekilde geri döndürür.
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