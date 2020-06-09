﻿using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Web.Mvc;
using FreeTime1.Models;

namespace FreeTime1.Controllers
{
    public class NguoiDungsController : Controller
    {
        private QLTapHoaEntities db = new QLTapHoaEntities();

        // GET: NguoiDungs
        public ActionResult Index()
        {
            return View(db.NguoiDungs.ToList());
        }

        // GET: NguoiDungs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguoiDung nguoiDung = db.NguoiDungs.Find(id);
            if (nguoiDung == null)
            {
                return HttpNotFound();
            }
            return View(nguoiDung);
        }

        // GET: NguoiDungs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NguoiDungs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaiKhoan,MatKhau,NhapLaiMatKhau,ChucVu,HoTen,SDT,Anh,DiaChi,GioiTinh")] NguoiDung nguoiDung)
        {
            if (ModelState.IsValid)
            {
                nguoiDung.MatKhau = SecurePasswordHasher.Hash(nguoiDung.MatKhau);
                nguoiDung.NhapLaiMatKhau = nguoiDung.MatKhau;
                nguoiDung.Anh = "anh";
                int count = db.NguoiDungs.Count() + 1;
                if (nguoiDung.ChucVu == "Quản lý") nguoiDung.MaND = "QL" + count.ToString();
                else if (nguoiDung.ChucVu == "Nhân viên") nguoiDung.MaND = "NV" + count.ToString();
                else return View(nguoiDung);
                db.NguoiDungs.Add(nguoiDung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nguoiDung);
        }

        // GET: NguoiDungs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguoiDung nguoiDung = db.NguoiDungs.Find(id);
            if (nguoiDung == null)
            {
                return HttpNotFound();
            }
            return View(nguoiDung);
        }

        // POST: NguoiDungs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaND,TaiKhoan,MatKhau,ChucVu,HoTen,SDT,Anh,DiaChi,GioiTinh")] NguoiDung nguoiDung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nguoiDung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nguoiDung);
        }

        // GET: NguoiDungs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NguoiDung nguoiDung = db.NguoiDungs.Find(id);
            if (nguoiDung == null)
            {
                return HttpNotFound();
            }
            return View(nguoiDung);
        }

        // POST: NguoiDungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NguoiDung nguoiDung = db.NguoiDungs.Find(id);
            db.NguoiDungs.Remove(nguoiDung);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
