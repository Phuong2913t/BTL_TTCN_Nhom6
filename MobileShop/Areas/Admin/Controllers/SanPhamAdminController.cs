using MobileShop.Models.BUS;
using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileShop.Areas.Admin.Controllers
{
    public class SanPhamAdminController : Controller
    {
        // GET: Admin/SanPhamAdmin
        public ActionResult Index()
        {
            return View(ShopOnlineBUS.DanhSachSP());
        }

        // GET: Admin/SanPhamAdmin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/SanPhamAdmin/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiSanPham = new SelectList(LoaiSanPhamBUS.DanhSach(), "MaLoaiSanPham", "TenloaiSanPham");
            ViewBag.MaNhaSanXuat = new SelectList(NhaSanXuatBUS.DanhSach(), "MaNhaSanXuat", "TenNhaSanXuat");
            return View();
        }

        // POST: Admin/SanPhamAdmin/Create
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(SanPham sp)
        {
            try
            {
                // TODO: Add insert logic here
                var hpf = HttpContext.Request.Files[0];
                if(hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + ".png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.HinhChinh = sp.MaSanPham + ".png";
                }
                hpf = HttpContext.Request.Files[1];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + "_1.png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh1 = sp.MaSanPham + "_1.png";
                }
                hpf = HttpContext.Request.Files[2];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + "_2.png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh2 = sp.MaSanPham + "_2.png";
                }
                hpf = HttpContext.Request.Files[3];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + "_3.png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh3 = sp.MaSanPham + "_3.png";
                }
                hpf = HttpContext.Request.Files[4];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + "_4.png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh4 = sp.MaSanPham + "_4.png";
                }
                sp.SoLuongDaBan = 0;
                sp.LuotView = 0;
                sp.TinhTrang = "0";
                ShopOnlineBUS.ThemSP(sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPhamAdmin/Edit/5
        public ActionResult Edit(String id)
        {
            ViewBag.MaLoaiSanPham = new SelectList(LoaiSanPhamBUS.DanhSach(), "MaLoaiSanPham", "TenloaiSanPham", ShopOnlineBUS.Describe(id).MaLoaiSanPham);
            ViewBag.MaNhaSanXuat = new SelectList(NhaSanXuatBUS.DanhSach(), "MaNhaSanXuat", "TenNhaSanXuat", ShopOnlineBUS.Describe(id).MaNhaSanXuat);
            return View(ShopOnlineBUS.Describe(id));
        }

        // POST: Admin/SanPhamAdmin/Edit/5
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(String id, SanPham sp)
        {
            try
            {
                // TODO: Add update logic here
                var hpf = HttpContext.Request.Files[0];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + ".png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.HinhChinh = sp.MaSanPham + ".png";
                }
                hpf = HttpContext.Request.Files[1];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + "_1.png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh1 = sp.MaSanPham + "_1.png";
                }
                hpf = HttpContext.Request.Files[2];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + "_2.png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh2 = sp.MaSanPham + "_2.png";
                }
                hpf = HttpContext.Request.Files[3];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + "_3.png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh3 = sp.MaSanPham + "_3.png";
                }
                hpf = HttpContext.Request.Files[4];
                if (hpf.ContentLength > 0)
                {
                    string fileName = sp.MaSanPham;
                    string fullPathWithFileName = "~/Asset/img/" + fileName + "_4.png";
                    hpf.SaveAs(Server.MapPath(fullPathWithFileName));
                    sp.Hinh4 = sp.MaSanPham + "_4.png";
                }
                sp.SoLuongDaBan = 0;
                sp.LuotView = 0;
                sp.TinhTrang = "0";
                ShopOnlineBUS.UpdateSP(id, sp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/SanPhamAdmin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/SanPhamAdmin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
