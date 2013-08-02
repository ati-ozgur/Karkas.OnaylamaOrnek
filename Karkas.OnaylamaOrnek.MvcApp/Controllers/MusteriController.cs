using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Karkas.OnaylamaOrnek.Bs;
using Karkas.OnaylamaOrnek.TypeLibrary;

namespace Karkas.OnaylamaOrnek.MvcApp.Controllers
{
    public class MusteriController : _BaseKarkasController
    {
        //
        // GET: /Musteri/

        public ActionResult Index()
        {
			MusteriBs bs = new MusteriBs();
			var list = bs.SorgulaHepsiniGetir();
			return View(list);
        }

        //
        // GET: /Musteri/Detay/5

        public ActionResult Detay(int key)
        {
			MusteriBs bs = new MusteriBs();
			Musteri dto = bs.SorgulaMusteriKeyIle(key);
			if (dto == null)
			{
				return HttpNotFound();
			}
			return View(dto);
        }

        //
        // GET: /Musteri/Create

        public ActionResult Ekle()
        {
            return View();
        }

        //
        // POST: /Musteri/Ekle

        [HttpPost]
		[ValidateAntiForgeryToken]
        public ActionResult Ekle(Musteri dto)
        {
			  try
				{
					if (ModelState.IsValid)
					{
						MusteriBs bs = new MusteriBs();
						bs.Ekle(dto);
						MesajEkleBasari(" Musteri  başarı ile eklenmiştir");
						return RedirectToAction("Index");
					}
				}
				catch (Exception ex)
				{
					MesajEkleHata("Ekleme İşlemi Sırasında Hata oluştu",ex,dto);
				}
				return View(dto);
        }

        //
        // GET: /Musteri/Guncelle/5

        public ActionResult Guncelle(int key)
        {
			MusteriBs bs = new MusteriBs();
			Musteri dto = bs.SorgulaMusteriKeyIle(key);
			if (dto == null)
			{
				return HttpNotFound();
			}
			return View(dto);
        }

        //
        // POST: /Musteri/Guncelle/5

        [HttpPost]
        public ActionResult Guncelle(int key, Musteri dto)
        {
			  try
				{
					if (ModelState.IsValid)
					{
						MusteriBs bs = new MusteriBs();
						bs.Guncelle(dto);
						MesajEkleBasari("Musteri  başarı ile güncellenmiştir");
						return RedirectToAction("Index");
					}
				}
				catch (Exception ex)
				{
					MesajEkleHata("Ekleme İşlemi Sırasında Hata oluştu",ex,dto);
				}
				return View(dto);
        }

        //
        // GET: /Musteri/Sil/5

        public ActionResult Sil(int key)
        {
         	MusteriBs bs = new MusteriBs();
			Musteri dto = bs.SorgulaMusteriKeyIle(key);
			if (dto == null)
			{
				return HttpNotFound();
			}
			return View(dto);
        }

        //
        // POST: /Musteri/Sil/5

        [HttpPost]
        public ActionResult Sil(int key,  Musteri dto)
        {
            try
            {
	         	MusteriBs bs = new MusteriBs();
				bs.Sil(key);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
