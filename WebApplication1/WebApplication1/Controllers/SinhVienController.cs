using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SinhVienController : Controller
    {
        // GET: SinhVien
        public ActionResult index()
        {
            return View();

        }
        public ActionResult SinhVien()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SinhVien(string MaSinhVien, string HoTenSinhVien)
        {
            ViewBag.Thongtin = MaSinhVien + "" + HoTenSinhVien;
            return View();
        }
    }
}
