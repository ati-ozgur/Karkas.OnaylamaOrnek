using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Karkas.OnaylamaOrnek.Bs;
using Karkas.OnaylamaOrnek.TypeLibrary;

namespace Karkas.OnaylamaOrnek.MvcApp.Controllers
{
    public class MusteriController : Controller
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
						return RedirectToAction("Index");
					}
				}
				catch (Exception ex)
				{
					ModelState.AddModelError("", "Ekleme İşlemi Sırasında Hata oluştu" + ex.Message);
				}
				return View(dto);
        }

        //
        // GET: /Musteri/Guncelle/5

        public ActionResult Guncelle(int id)
        {
            return View();
        }

        //
        // POST: /Musteri/Edit/5

        [HttpPost]
        public ActionResult Guncelle(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Musteri/Delete/5

        public ActionResult Sil(int id)
        {
            return View();
        }

        //
        // POST: /Musteri/Delete/5

        [HttpPost]
        public ActionResult Sil(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
