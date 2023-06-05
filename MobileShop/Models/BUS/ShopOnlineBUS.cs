using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileShop.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham>("Select * from SanPham where TinhTrang = 0");
        }
        public static SanPham Describe(String a)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<SanPham>("Select * from SanPham where MaSanPham = @0", a);
        }
        public static IEnumerable<SanPham> DanhSachSP()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham>("Select * from SanPham");
        }
        public static void ThemSP(SanPham sp)
        {
            var db = new ShopOnlineConnectionDB();
            db.Insert(sp);
        }
    }
}