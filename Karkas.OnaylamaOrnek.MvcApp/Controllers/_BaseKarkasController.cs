using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Karkas.OnaylamaOrnek.MvcApp.Controllers
{
    public class _BaseKarkasController : Controller
    {
        public void MesajEkleUyari(string mesaj)
        {
            TempData.Add(Alarmlar.UYARI, mesaj);
        }
        public void MesajEkleBasari(string mesaj)
        {
            TempData.Add(Alarmlar.BASARILI, mesaj);
        }

        public void MesajEkleBilgi(string mesaj)
        {
            TempData.Add(Alarmlar.BILGI, mesaj);
        }

        public void MesajEkleHata(string mesaj)
        {
            TempData.Add(Alarmlar.HATA, mesaj);
        }

    }


    public static class Alarmlar
    {
        public const string BASARILI = "success";
        public const string UYARI = "attention";
        public const string HATA = "error";
        public const string BILGI = "info";

        public static string[] ALL
        {
            get { return new[] { BASARILI, UYARI, HATA, BILGI }; }
        }
    }

}