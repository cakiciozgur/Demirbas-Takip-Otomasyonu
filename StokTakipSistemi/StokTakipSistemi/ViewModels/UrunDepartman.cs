using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StokTakipSistemi.Models;
namespace StokTakipSistemi.ViewModels
{
    public class UrunDepartman
    {
        public tblUrunGenel Urun { get; set; }
        public List<tblDepartman> Departmanlar;
    }
}