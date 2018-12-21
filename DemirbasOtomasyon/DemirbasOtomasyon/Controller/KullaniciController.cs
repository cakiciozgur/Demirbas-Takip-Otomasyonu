using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemirbasOtomasyon.Model;
using DemirbasOtomasyon.View;
namespace DemirbasOtomasyon.Controller
{
    public static class KullaniciController
    {
        public static List<Kullanıcılar> KullanicilariListele()
        {
            using (var context = new DemirbasTakipEntitiess())
            {
                var result = context.Kullanıcılar.ToList();
                return result.ToList();
            }
        }
        public static Kullanıcılar AdminGiris(Kullanıcılar kullanici)
        {
            if (string.IsNullOrEmpty(kullanici.kullaniciAdi) && string.IsNullOrEmpty(kullanici.kullaniciSifre.ToString()))
            {
                throw new Exception("Kullanici Verileri Boş Geçilemez !");
            }
            using (var context = new DemirbasTakipEntitiess())
            {
                var result = context.Kullanıcılar.FirstOrDefault(x => x.kullaniciAdi == kullanici.kullaniciAdi && x.kullaniciSifre == kullanici.kullaniciSifre);

                //if (result == null || result.Silindi == Convert.ToBoolean(EDeleted.silindi))
                //{
                //    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                //}
                var roleResult = context.Kullanıcılar.FirstOrDefault(x => x.kullaniciID == result.kullaniciID);
                if (roleResult.rolID != (int)eRoles.Admin)
                {
                    throw new Exception("Kullanıcı Bilgileriniz Bu Sayfayı Açmak İçin Yeterli Değil ! \n Lütfen Standart Kullanıcı Biriminden Giriş Yapınız !");
                }
                return result;
            }
        }
        public static Kullanıcılar BirimYetkilisiGiris(Kullanıcılar kullanici)
        {
            if (string.IsNullOrEmpty(kullanici.kullaniciAdi) && string.IsNullOrEmpty(kullanici.kullaniciSifre.ToString()))
            {
                throw new Exception("Kullanici Verileri Boş Geçilemez !");
            }
            using (var context = new DemirbasTakipEntitiess())
            {
                var result = context.Kullanıcılar.FirstOrDefault(x => x.kullaniciAdi == kullanici.kullaniciAdi && x.kullaniciSifre == kullanici.kullaniciSifre);

                //if (result == null || result.Silindi == Convert.ToBoolean(EDeleted.silindi))
                //{
                //    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                //}
                var roleResult = context.Kullanıcılar.FirstOrDefault(x => x.kullaniciID == result.kullaniciID);
                if (roleResult.rolID != (int)eRoles.BirimYetkilisi)
                {
                    throw new Exception("Kullanıcı Bilgileriniz Bu Sayfayı Açmak İçin Yeterli Değil ! \n Lütfen Standart Kullanıcı Biriminden Giriş Yapınız !");
                }
                return result;
            }
        }
        public static Kullanıcılar SatinAlmaYetkilisiGiris(Kullanıcılar kullanici)
        {
            if (string.IsNullOrEmpty(kullanici.kullaniciAdi) && string.IsNullOrEmpty(kullanici.kullaniciSifre.ToString()))
            {
                throw new Exception("Kullanici Verileri Boş Geçilemez !");
            }
            using (var context = new DemirbasTakipEntitiess())
            {
                var result = context.Kullanıcılar.FirstOrDefault(x => x.kullaniciAdi == kullanici.kullaniciAdi && x.kullaniciSifre == kullanici.kullaniciSifre);

                //if (result == null || result.Silindi == Convert.ToBoolean(EDeleted.silindi))
                //{
                //    throw new AuthenticationException("Kullanıcı Girişi Başarısız !");
                //}
                var roleResult = context.Kullanıcılar.FirstOrDefault(x => x.kullaniciID == result.kullaniciID);
                if (roleResult.rolID != (int)eRoles.SatinAlmaBirimi)
                {
                    throw new Exception("Kullanıcı Bilgileriniz Bu Sayfayı Açmak İçin Yeterli Değil ! \n Lütfen Standart Kullanıcı Biriminden Giriş Yapınız !");
                }
                return result;
            }
        }

    }
}
