using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanQuaLuuNiem.Models;

namespace WebBanQuaLuuNiem.Controllers
{
    public class AccountController : Controller
    {
        dbQuaLuuNiemDataContext db = new dbQuaLuuNiemDataContext();
        public ActionResult TrangChu()
        {
            return View();
        }
        // GET: Account
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection collection, KhachHang kh)
        {
            var hoten = collection["HoTen"];
            var tendn = collection["TaiKhoan"];
            var matkhau = collection["MatKhau"];
            var matkhaunhaplai = collection["MatKhauNhapLai"];
            var diachi = collection["DiaChi"];
            var dienthoai = collection["SDT"];
            if (String.IsNullOrEmpty(hoten))
            {
                ViewData["Loi1"] = "Họ tên khách hàng không được để trống";
            }
            else if(String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi2"] = "phải nhập tên đăng nhập";
            }
            else if(String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi3"] = "Phải nhập mật khẩu";
            }
            else if(String.IsNullOrEmpty(matkhaunhaplai))
            {
                ViewData["Loi4"] = "Phải nhập lại mật khẩu";
            }
            else if(String.IsNullOrEmpty(diachi))
            {
                ViewData["Loi5"] = "Phải nhập địa chỉ";
            }
            else if(String.IsNullOrEmpty(dienthoai))
            {
                ViewData["Loi6"] = "Phải nhập số điện thoại";
            }
            else
            {
                //Gán giá trị cho đối tượng được tạo mới
                //KhachHang k = new KhachHang();
                kh.HoTen = hoten;
                kh.TaiKhoan = tendn;
                kh.MatKhau = matkhau;
                kh.DiaChi = diachi;
                kh.SDT = dienthoai;
                db.KhachHangs.InsertOnSubmit(kh);
                db.SubmitChanges();
                return RedirectToAction("DangNhap");
            }
            return this.DangKy();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var tendn = collection["TaiKhoan"];
            var matkhau = collection["MatKhau"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "phải nhập tên đăng nhập";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }
            KhachHang kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan == tendn && n.MatKhau == matkhau);
            if (kh != null)
            {
                //ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["TaiKhoan"] = kh;
                return RedirectToAction("TrangChu", "QuaLuuNiem");
            }
            else
            {
                ViewBag.ThongBao = "Tên đặng nhập hoặc mật khẩu không đúng";
            }
            return View();
        }
    }
}