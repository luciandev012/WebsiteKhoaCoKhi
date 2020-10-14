using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteKhoaCoKhi.Areas.Admin.Models;
using Model.DAO;
using WebsiteKhoaCoKhi.Common;

namespace WebsiteKhoaCoKhi.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new AdminAccountDAO();
                var result = dao.Login(model.Username, Encryptor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var user = dao.GetAdminByUserName(model.Username);
                    var userSession = new AdminLogin();
                    userSession.AdminName = user.userName;

                    userSession.AdminID = user.id;
                    Session.Add(Common.CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if(result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khóa");
                }
                else
                {
                    ModelState.AddModelError("", "Sai mật khẩu");
                }
            }
            else
            {
                
            }
            return View("Index");
        }
    }
}