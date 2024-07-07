using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCNPM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GioiThieu()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LichTap()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult DichVu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult HuanLuyenVien()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult TinTuc()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}