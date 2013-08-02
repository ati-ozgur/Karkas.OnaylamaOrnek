using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Karkas.Core.TypeLibrary;
using log4net;
using Newtonsoft.Json;


namespace Karkas.Web.Mvc.Controllers
{
    public class _BaseKarkasController : Controller
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(_BaseKarkasController));

        public void MesajEkleUyari(string mesaj, BaseTypeLibrary dto = null)
        {
            TempData[Alarmlar.UYARI] = mesaj;
            if (dto == null)
            {
                log.Warn(mesaj);
            }
            else
            {
                string json = JsonConvert.SerializeObject(dto);
                log.Warn(mesaj + "json : " + json);
            }
        }

        public void MesajEkleBasari(string mesaj, BaseTypeLibrary dto = null)
        {
            TempData[Alarmlar.BASARILI] = mesaj;
            if (dto == null)
            {
                log.Debug(mesaj);
            }
            else
            {
                string json = JsonConvert.SerializeObject(dto);
                log.Debug(mesaj + "json : " + json);
            }
        }

        public void MesajEkleBilgi(string mesaj, BaseTypeLibrary dto = null)
        {
            TempData[Alarmlar.BILGI] = mesaj;
            if (dto == null)
            {
                log.Info(mesaj);
            }
            else
            {
                string json = JsonConvert.SerializeObject(dto);
                log.Info(mesaj + "json : " + json);
            }
        }

        public void MesajEkleHata(string mesaj, Exception ex = null, BaseTypeLibrary dto = null)
        {
            TempData[Alarmlar.HATA] = mesaj;
            if (dto == null)
            {
                log.Error(mesaj,ex);
            }
            else
            {
                string json = JsonConvert.SerializeObject(dto);
                log.Error(mesaj + "json : " + json,ex);
            }
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