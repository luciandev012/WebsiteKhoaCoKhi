using Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteKhoaCoKhi.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index(string metaTitle)
        {
            var dao = new NewDAO();
            var subDAO = new SubMenuDAO();
            var cateDao = new CategoryNewDAO();
            var model = dao.GetNewByMetaTitle(metaTitle);
            ViewBag.Category = cateDao.GetCategoryNew(model.categoryId);
            string cateTitle = cateDao.GetCategoryMetaTitle((int)model.categoryId);
            int menuType = subDAO.GetTypeMenu(cateTitle);
            ViewBag.SubMenus = subDAO.ListSubMenuByType(menuType);
            ViewBag.SubMenuId = subDAO.GetId(cateTitle);
            ViewBag.SubText = subDAO.GetText(cateTitle);
            dao.UpdateView(metaTitle);
            return View(model);
        }
        public ActionResult News(string metaTitle, int page = 1)
        {
            var dao = new SubMenuDAO();
            int typeMenu = dao.GetTypeMenu(metaTitle);
            ViewBag.SubMenus = dao.ListSubMenuByType(typeMenu);
            ViewBag.SubMenuId = dao.GetId(metaTitle);
            ViewBag.SubText = dao.GetText(metaTitle);


            var cateDao = new CategoryNewDAO();
            int cateId = cateDao.GetCategoryId(metaTitle);
            var newDao = new NewDAO();
            var model = newDao.listAllByType(cateId, page, 10);
            return View(model);
        } 
    }
}