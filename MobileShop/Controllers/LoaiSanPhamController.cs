using MobileShop.Models.BUS;
using PagedList;
using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobileShop.Controllers
{
    public class LoaiSanPhamController : Controller
    {
        // GET: LoaiSanPham
        public ActionResult Index(String id, int page = 1, int pageSize = 3)
        {
            var ds = LoaiSanPhamBUS.ChiTiet(id).ToPagedList(page, pageSize);
            return View(ds);
        }
    }
}