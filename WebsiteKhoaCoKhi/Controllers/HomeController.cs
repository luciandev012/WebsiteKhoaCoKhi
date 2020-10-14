using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteKhoaCoKhi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            var dao = new MenuDAO();
            var model = dao.ListAllMenu();
            
            return PartialView(model);
        }
        public ActionResult NewsMenu()
        {
            var dao = new NewDAO();
            var model = dao.ListHighLigtNew();
            return PartialView(model);
        }
        public ActionResult NewsEvent()
        {
            int count = 2;
            var dao = new NewDAO();
            var model = dao.GetLastestNew(count);
            return PartialView(model);
        }
        public ActionResult Notice()
        {
            int count = 2;
            var dao = new NewDAO();
            var model = dao.GetLastestNotice(count);
            return PartialView(model);
        }
    }
}