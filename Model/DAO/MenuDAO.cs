using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class MenuDAO
    {
        WebsiteKhoaCoKhiDbContext db = null;

        public MenuDAO()
        {
            db = new WebsiteKhoaCoKhiDbContext();
        }
        
        public List<Menu> ListAllMenu()
        {
            SubMenuDAO sub = new SubMenuDAO();
            var model = db.Menus.OrderBy(x => x.displayOrder).ToList();
            foreach (var item in model)
            {
                item.SubMenus.Clear();
                item.SubMenus = sub.ListSubMenuByType(item.typeMenu);
            }
            return model;
        }
    }
}
