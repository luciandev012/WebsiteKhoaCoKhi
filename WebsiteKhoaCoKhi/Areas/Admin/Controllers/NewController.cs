using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.DAO;
using WebsiteKhoaCoKhi.Common;
using PagedList;

namespace WebsiteKhoaCoKhi.Areas.Admin.Controllers
{
    public class NewController : BaseController
    {
        // GET: Admin/New
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            var dao = new NewDAO();
            var model = dao.listAll(searchString ,page, pageSize);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            SetViewBag();
            return View();
        }

        [HttpPost]
        public ActionResult Create(New anew)
        {
            if (ModelState.IsValid)
            {
                var dao = new NewDAO();
                anew.createdDate = DateTime.Now;
                var session = (AdminLogin)Session[CommonConstants.USER_SESSION];
                anew.createdBy = session.AdminName;
                anew.newView = 0;
                long id = dao.Insert(anew);
                if(id > 0)
                {
                    SetAlert("Thêm tin thành công!", "success");
                    return RedirectToAction("Index", "New");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm tin không thành công");
                }
            }
            SetViewBag();
            return View("Index");
        }
        public ActionResult Edit(int id)
        {
            var anew = new NewDAO().FindById(id);
            SetViewBag(anew.categoryId);
            return View(anew);
        }
        [HttpPost]
        public ActionResult Edit(New anew)
        {
            if (ModelState.IsValid)
            {
                var dao = new NewDAO();
                var session = (AdminLogin)Session[CommonConstants.USER_SESSION];
                anew.modifyBy = session.AdminName;
                
                var rs = dao.Update(anew);
                if (rs)
                {
                    SetAlert("Sửa tin thành công!", "success");
                    return RedirectToAction("Index", "New");
                }
                else
                {
                    ModelState.AddModelError("", "Sửa tin không thành công");
                }
            }
            SetViewBag(anew.categoryId);
            return View("Index");
        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var dao = new NewDAO();
            dao.Delete(id);
            SetAlert("Xóa tin thành công!", "success");
            return RedirectToAction("Index");
        }
        public void SetViewBag(int? selectedId = null)
        {
            var dao =  new CategoryNewDAO();
            ViewBag.categoryId = new SelectList(dao.ListAll(), "id", "name", selectedId);

        }
    }
}