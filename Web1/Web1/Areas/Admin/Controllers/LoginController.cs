using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Web1.Areas.Admin.Code;
using Web1.Areas.Admin.Models;

namespace Web1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            //var result = new UserModel().login(model.Taikhoan, model.Matkhau);
            if(Membership.ValidateUser(model.Taikhoan,model.Matkhau)  && ModelState.IsValid)
            {
               // SessionHelper.SetSession(new UserSession() { Taikhoan = model.Taikhoan });
                FormsAuthentication.SetAuthCookie(model.Taikhoan, model.Luu);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}