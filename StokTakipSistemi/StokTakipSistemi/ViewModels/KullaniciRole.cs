using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StokTakipSistemi.Models;
namespace StokTakipSistemi.ViewModels
{
    public class KullaniciRole
    {
        public tblKullanıcı Kullanici { get; set; }
        public List<tblRole> Roller;
    }
}