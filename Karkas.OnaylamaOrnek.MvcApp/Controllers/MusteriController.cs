using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Karkas.OnaylamaOrnek.Bs;

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
        // POST: /Musteri/Create

        [HttpPost]
        public ActionResult Ekle(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Musteri/Edit/5

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
