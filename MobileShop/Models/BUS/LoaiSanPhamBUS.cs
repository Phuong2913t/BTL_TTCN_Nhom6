using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileShop.Models.BUS
{
    public class LoaiSanPhamBUS
    {
        //---------------------- Khách hàng
        public static IEnumerable<LoaiSanPham> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<LoaiSanPham>("Select * from LoaiSanPham where TinhTrang = '0'");
        }
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham>("Select * from SanPham where MaLoaiSanPham = '" + id + "'");
        }
        //--------------------- Admin
        public static IEnumerable<LoaiSanPham> DanhSachAdmin()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<LoaiSanPham>("Select * from LoaiSanPham");
        }
        public static void ThemLSP(LoaiSanPham lsp)
        {
            var db = new ShopOnlineConnectionDB();
            db.Insert(lsp);
        }
        public static LoaiSanPham ChiTietAdmin(String id)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<LoaiSanPham>("Select * from LoaiSanPham where MaLoaiSanPham = '" + id + "'");
        }
        public static void UpdateLSP(String id, LoaiSanPham lsp)
        {
            var db = new ShopOnlineConnectionDB();
            db.Update(lsp, id);
        }
    }
}