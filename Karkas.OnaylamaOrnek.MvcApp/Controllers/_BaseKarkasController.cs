using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;


namespace Karkas.OnaylamaOrnek.MvcApp.Controllers
{
    public class _BaseKarkasController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(_BaseKarkasController));

        public void MesajEkleUyari(string mesaj)
        {
            TempData.Add(Alarmlar.UYARI, mesaj);
            log.Warn(mesaj);
        }
        public void MesajEkleBasari(string mesaj)
        {
            TempData.Add(Alarmlar.BASARILI, mesaj);
            log.Debug(mesaj);
        }

        public void MesajEkleBilgi(string mesaj)
        {
            TempData.Add(Alarmlar.BILGI, mesaj);
            log.Info(mesaj);
        }

        public void MesajEkleHata(string mesaj)
        {
            TempData.Add(Alarmlar.HATA, mesaj);
            log.Error(mesaj);
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