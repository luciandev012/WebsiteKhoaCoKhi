using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteKhoaCoKhi.Areas.Admin.Controllers
{
    public class MenuController : Controller
    {
        // GET: Admin/Menu
        public ActionResult Index()
        {
            var dao = new MenuDAO();
            var model = dao.ListAllMenu();
            return View(model);
        }
    }
}