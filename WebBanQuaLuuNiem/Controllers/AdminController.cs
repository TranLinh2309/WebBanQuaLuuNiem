using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanQuaLuuNiem.Models;
using System.IO;
using PagedList;
using PagedList.Mvc;


namespace WebBanQuaLuuNiem.Controllers
{
    public class AdminController : Controller
    {
        dbQuaLuuNiemDataContext db = new dbQuaLuuNiemDataContext();
        // GET: Admin
        public ActionResult TrangChu()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult SanPham(int? page)
        {
            int pageNumber = (page ?? 1);
            int pageSize = 7;
            //return View(db.SanPhams.ToList());
            return View(db.SanPhams.ToList().OrderBy(n => n.MaSP).ToPagedList(pageNumber, pageSize));
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            var tendn = collection["username"];
            var matkhau = collection["password"];
            if (String.IsNullOrEmpty(tendn))
            {
                ViewData["Loi1"] = "Phải nhập Tên đăng nhập";
            }
            else if(String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu";
            }
            else
            {
                ADMIN ad = db.ADMINs.SingleOrDefault(n => n.TKAdmin == tendn && n.PassAdmin == matkhau);
                if (ad != null)
                {
                    Session["Taikhoanadmin"] = ad;
                    return RedirectToAction("TrangChu", "Admin");

                }
                else
                {
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Themmoisanpham()
        {
            //Dua du lieu vao dropdownList
            //Lay ds tu tabke chu de, sắp xep tang dan trheo ten chu de, chon lay gia tri Ma CD, hien thi thi Tenchude
            ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList().OrderBy(n => n.TenChatLieu), "MaChatLieu", "TenChatLieu");
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Themmoisanpham( SanPham sanpham, HttpPostedFileBase fileupload)
        {

            //Dua du lieu vao dropdownload
            ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList().OrderBy(n => n.TenChatLieu), "MaChatLieu", "TenChatLieu");
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");

            //Kiem tra duong dan file
            if (fileupload == null)
            {
                ViewBag.ThongBao = "Vui lòng chọn ảnh bìa";
                return View();
            }
            //Them vao CSDL
            else
            {
                if (ModelState.IsValid)
                {
                    //Luu ten fie, luu y bo sung thu vien using System.IO;
                    var fileName = Path.GetFileName(fileupload.FileName);
                    //Luu duong dan cua file
                    var path = Path.Combine(Server.MapPath("~/Images"), fileName);
                    //Kiem tra hình anh ton tai chua?
                    if (System.IO.File.Exists(path))
                        ViewBag.Thongbao = "Hình ảnh đã tồn tại";
                    else
                    {
                        //Luu hinh anh vao duong dan
                        fileupload.SaveAs(path);
                    }
                    
                    sanpham.AnhBia = fileName;
                    //Luu vao CSDL
                    db.SanPhams.InsertOnSubmit(sanpham);
                    db.SubmitChanges();
                }
                return RedirectToAction("SanPham");
            }
        }
        public ActionResult ChiTietSanPham(int id)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(N => N.MaSP == id);
            ViewBag.MaSP = sp.MaSP;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
        public ActionResult XoaSanPham(int id)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(N => N.MaSP == id);
            ViewBag.MaSP = sp.MaSP;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sp);
        }
        [HttpPost, ActionName("XoaSanPham")]
        public ActionResult XacNhanXoa(int id)
        {
            SanPham sp = db.SanPhams.SingleOrDefault(N => N.MaSP == id);
            ViewBag.MaSP = sp.MaSP;
            if (sp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.SanPhams.DeleteOnSubmit(sp);
            db.SubmitChanges();
            return RedirectToAction("SanPham");
        }
        [HttpGet]
        public ActionResult SuaSanPham(int id)
        {
            SanPham sanpham = db.SanPhams.SingleOrDefault(n => n.MaSP == id);
            
            if (sanpham == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList().OrderBy(n => n.TenChatLieu), "MaChatLieu", "TenChatLieu", sanpham.MaChatLieu);
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC", sanpham.MaNCC);
            return View(sanpham);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaSanPham(SanPham sanpham, HttpPostedFileBase fileupload)
        {

            //Dua du lieu vao dropdownload
            ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList().OrderBy(n => n.TenChatLieu), "MaChatLieu", "TenChatLieu");
            ViewBag.MaNCC = new SelectList(db.NhaCungCaps.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");

            SanPham sp = db.SanPhams.Single(n => n.MaSP == sanpham.MaSP);
           
            if (fileupload != null)
            {
                var fileName = Path.GetFileName(fileupload.FileName);
                DateTime localDate = DateTime.Now;
                String date_str = localDate.ToString("ddMMyyyy_HHmmss");
                fileName = date_str + "_" + fileName;
                var path = Path.Combine(Server.MapPath("~/Images"), fileName);
                    //Kiem tra hình anh ton tai chua?
                if (System.IO.File.Exists(path))
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                else
                {
                        //Luu hinh anh vao duong dan
                        fileupload.SaveAs(path);
                }
                sanpham.AnhBia = fileName;
                sp.AnhBia = sanpham.AnhBia;
            }
            sp.TenSP = sanpham.TenSP;
            sp.GiaBan = sanpham.GiaBan;
            sp.MoTa = sanpham.MoTa; 
            if (sanpham.NgayCapNhat != null)
            {
                sp.NgayCapNhat = sanpham.NgayCapNhat;
            }
            sp.SoLuongTon = sanpham.SoLuongTon;
            sp.MaNCC = sanpham.MaNCC;
            sp.MaChatLieu = sanpham.MaChatLieu;
            db.SubmitChanges();
            return RedirectToAction("SanPham");
        }
        public ActionResult NhaCungCap(/*int? page*/)
        {
            //int pageNumber = (page ?? 1);
            //int pageSize = 7;
            return View(db.NhaCungCaps.ToList());
            //return View(db.SanPhams.ToList().OrderBy(n => n.MaSP).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult ThemMoiNCC()
        {
            //Dua du lieu vao dropdownList
            //Lay ds tu tabke chu de, sắp xep tang dan trheo ten chu de, chon lay gia tri Ma CD, hien thi thi Tenchude
            //ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList().OrderBy(n => n.TenChatLieu), "MaChatLieu", "TenChatLieu");
            // ViewBag.MaNCC = new SelectList(db.NhaCungCaps.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoiNCC(NhaCungCap ncc)
        {
            //Dua du lieu vao dropdownList
            //Lay ds tu tabke chu de, sắp xep tang dan trheo ten chu de, chon lay gia tri Ma CD, hien thi thi Tenchude
            //ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList().OrderBy(n => n.TenChatLieu), "MaChatLieu", "TenChatLieu");
            // ViewBag.MaNCC = new SelectList(db.NhaCungCaps.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");
            db.NhaCungCaps.InsertOnSubmit(ncc);
            db.SubmitChanges();
            return RedirectToAction("NhaCungCap");
        }
        public ActionResult ChiTietNCC(int id)
        {
            NhaCungCap ncc = db.NhaCungCaps.SingleOrDefault(N => N.MaNCC == id);
            ViewBag.MaNCC = ncc.MaNCC;
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ncc);
        }
        [HttpGet]
        public ActionResult XoaNCC(int id)
        {
            NhaCungCap ncc = db.NhaCungCaps.SingleOrDefault(N => N.MaNCC == id);
            ViewBag.MaNCC = ncc.MaNCC;
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ncc);
        }
        [HttpPost, ActionName("XoaNCC")]
        public ActionResult XacNhanXoaNCC(int id)
        {
            NhaCungCap ncc = db.NhaCungCaps.SingleOrDefault(N => N.MaNCC == id);
            ViewBag.MaNCC = ncc.MaNCC;
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            db.NhaCungCaps.DeleteOnSubmit(ncc);
            db.SubmitChanges();
            return View(ncc);                
        }
        [HttpGet]
        public ActionResult SuaNCC(int id)
        {
            NhaCungCap ncc = db.NhaCungCaps.SingleOrDefault(N => N.MaNCC == id);
            
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(ncc);
        }
        [HttpPost]
        public ActionResult SuaNCC(NhaCungCap ncc)
        {
            
            ViewBag.MaNCC = ncc.MaNCC;
            if (ncc == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            UpdateModel(ncc);
            db.SubmitChanges();
            return RedirectToAction("NhaCungCap");
        }
        public ActionResult ChuDe(/*int? page*/)
        {
            //int pageNumber = (page ?? 1);
            //int pageSize = 7;
            return View(db.ChatLieus.ToList());
            //return View(db.SanPhams.ToList().OrderBy(n => n.MaSP).ToPagedList(pageNumber, pageSize));
        }
        [HttpGet]
        public ActionResult ThemMoiCD()
        {
            //Dua du lieu vao dropdownList
            //Lay ds tu tabke chu de, sắp xep tang dan trheo ten chu de, chon lay gia tri Ma CD, hien thi thi Tenchude
            //ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList().OrderBy(n => n.TenChatLieu), "MaChatLieu", "TenChatLieu");
            // ViewBag.MaNCC = new SelectList(db.NhaCungCaps.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ThemMoiCD(ChatLieu cl)
        {
            //Dua du lieu vao dropdownList
            //Lay ds tu tabke chu de, sắp xep tang dan trheo ten chu de, chon lay gia tri Ma CD, hien thi thi Tenchude
            //ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList().OrderBy(n => n.TenChatLieu), "MaChatLieu", "TenChatLieu");
            // ViewBag.MaNCC = new SelectList(db.NhaCungCaps.ToList().OrderBy(n => n.TenNCC), "MaNCC", "TenNCC");
            db.ChatLieus.InsertOnSubmit(cl);
            db.SubmitChanges();
            return RedirectToAction("ChatLieu");
        }
        public ActionResult ChiTietCD(int id)
        {
            ChatLieu cl = db.ChatLieus.SingleOrDefault(N => N.MaChatLieu == id);
            ViewBag.MaChatLieu = cl.MaChatLieu;
            if (cl == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(cl);
        }
        [HttpGet]
        public ActionResult XoaCD(int id)
        {
            ChatLieu cl = db.ChatLieus.SingleOrDefault(N => N.MaChatLieu == id);
            ViewBag.MaChatLieu = cl.MaChatLieu;
            if (cl == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(cl);
        }
        [HttpPost, ActionName("XoaCD")]
        public ActionResult XacNhanXoaCD(int id)
        {
            ChatLieu cl = db.ChatLieus.SingleOrDefault(N => N.MaChatLieu == id);
            ViewBag.MaChatLieu = cl.MaChatLieu;
            if (cl == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            
            db.ChatLieus.DeleteOnSubmit(cl);
            db.SubmitChanges();
            return View(cl);
        }
        [HttpGet]
        public ActionResult SuaCD(int id)
        {
            ChatLieu cl = db.ChatLieus.SingleOrDefault(N => N.MaChatLieu == id);
            ViewBag.MaChatLieu = cl.MaChatLieu;
            if (cl == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(cl);
        }
        [HttpPost]
        public ActionResult SuaCD(ChatLieu cl)
        {


            ViewBag.MaChatLieu = cl.MaChatLieu;
            if (cl == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            UpdateModel(cl);
            db.SubmitChanges();
            return RedirectToAction("ChatLieu");
        }
    }
}