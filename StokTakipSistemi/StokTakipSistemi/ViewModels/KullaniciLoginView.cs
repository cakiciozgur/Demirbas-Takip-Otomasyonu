using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StokTakipSistemi.ViewModels
{
    public class KullaniciLoginView
    {
        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Giriniz")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "Kullanıcı Adı 50 Karakterden Fazla Oluşamaz")]
        [RegularExpression("^[A-Za-z0-9ÜİÖĞÇüiöğç_ ]{0,50}$", ErrorMessage = "Kullanıcı Adı Özel Karakterlerden(',-,? vs.) Oluşamaz ve 50 Karakterden Fazla Olamaz")]
        public string username { get; set; }

        [Required(ErrorMessage ="Lütfen Şifre Bilgisini Giriniz")]
        [Display(Name ="Şifre")]
        [MinLength(6,ErrorMessage ="Şifre 6 dan Az Sayıda Karakterden Oluşamaz!")]
        [StringLength(20,ErrorMessage ="Şifre 20 Karakterden Fazla olamaz")]
        public string password { get; set; }
    }
}