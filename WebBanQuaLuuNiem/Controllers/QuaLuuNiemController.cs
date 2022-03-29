using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanQuaLuuNiem.Models;
using PagedList;
using PagedList.Mvc;

namespace WebBanQuaLuuNiem.Controllers
{
    public class QuaLuuNiemController : Controller
    {
        dbQuaLuuNiemDataContext db = new dbQuaLuuNiemDataContext();
        // GET: QuaLuuNiem
        public ActionResult TrangChu(int ? page)
        {
            //tao bien quy dinh so sanr pham tren moi trang
            int pageSize = 5;
            int pageNum = (page ?? 1);
            //Lay sach moi
            var sanphammoi = Laysanphammoi(50);
            return View(sanphammoi.ToPagedList(pageNum,pageSize));
        }
        private List<SanPham> Laysanphammoi(int count)
        {
            return db.SanPhams.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }
        public ActionResult ChatLieu()
        {

            var chatlieu = from cl in db.ChatLieus select cl;
            return PartialView(chatlieu);
        }
        public ActionResult NhaCungCap()
        {
            var nhacungcap = from ncc in db.NhaCungCaps select ncc;
            return PartialView(nhacungcap);
        }
        public ActionResult SPTheoChatLieu(int id)
        {
            var sanpham = from s in db.SanPhams where s.MaChatLieu == id  select s;
            return View(sanpham);
        }
        public ActionResult SPTheoNhaCungCap(int id)
        {
            var nhacungcap = from s in db.SanPhams where s.MaNCC == id select s;
            return View(nhacungcap);
        }
        public ActionResult Details(int id)
        {
            var sanpham = from s in db.SanPhams
                          where s.MaSP== id
                          select s;
            return View(sanpham.Single());
        }


    }
}