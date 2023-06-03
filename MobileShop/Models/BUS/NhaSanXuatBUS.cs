using ShopOnlineConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobileShop.Models.BUS
{
    public class NhaSanXuatBUS
    {
        public static IEnumerable<NhaSanXuat> DanhSach()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<NhaSanXuat>("Select * from NhaSanXuat where TinhTrang = 0");
        }
        public static IEnumerable<NhaSanXuat> DanhSachAdmin()
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<NhaSanXuat>("Select * from NhaSanXuat");
        }
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new ShopOnlineConnectionDB();
            return db.Query<SanPham>("Select * from SanPham where MaNhaSanXuat = '" + id + "'");
        }
        public static void ThemNSX(NhaSanXuat nsx)
        {
            var db = new ShopOnlineConnectionDB();
            db.Insert(nsx);
        }
        public static NhaSanXuat ChiTietAdmin(String id)
        {
            var db = new ShopOnlineConnectionDB();
            return db.SingleOrDefault<NhaSanXuat>("Select * from NhaSanXuat where MaNhaSanXuat = '" + id + "'");
        }
        public static void UpdateNSX(String id, NhaSanXuat nsx)
        {
            var db = new ShopOnlineConnectionDB();
            db.Update(nsx,id);
        }
        //public void DeleteData(int id)
        //{
        //    using (var db = new MyDbContext())
        //    {
        //        var data = db.MyData.FirstOrDefault(x => x.Id == id);
        //        if (data != null)
        //        {
        //            db.MyData.Remove(data);
        //            db.SaveChanges();
        //        }
        //    }
        //}
    }
}