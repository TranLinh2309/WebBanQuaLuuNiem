using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanQuaLuuNiem.Models;
namespace WebBanQuaLuuNiem.Models
{
    public class GioHang
    {
        dbQuaLuuNiemDataContext db = new dbQuaLuuNiemDataContext();
        public int iMaSP { set; get; }
        public string sTenSP { set; get; }
        public string sAnhBia { set; get; }
        public Double dDonGia { set; get; }
        public int iSoLuong { set; get; }
        public Double dThanhTien
        {
            get { return iSoLuong * dDonGia; }
        }
        public GioHang(int MaSP)
        {
            iMaSP = MaSP;
            SanPham s = db.SanPhams.Single(n => n.MaSP == iMaSP);
            sTenSP = s.TenSP;
            sAnhBia = s.AnhBia;
            dDonGia = double.Parse(s.GiaBan.ToString());
            iSoLuong = 1;
        }
    }
}