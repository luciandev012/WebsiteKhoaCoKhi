using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class SubMenuDAO
    {
        WebsiteKhoaCoKhiDbContext db = null;

        public SubMenuDAO()
        {
            db = new WebsiteKhoaCoKhiDbContext();
        }
        public List<SubMenu> ListSubMenuByType(int typeMenu)
        {
            return db.SubMenus.Where(x => x.typeMenu == typeMenu).OrderBy(x => x.displayOrder).ToList();
        }
        public int GetTypeMenu(string metaTitle)
        {
            var item = db.SubMenus.SingleOrDefault(x => x.link == metaTitle);
            return item.typeMenu;
        }
        public int GetId(string metaTitle)
        {
            var item = db.SubMenus.SingleOrDefault(x => x.link == metaTitle);
            return item.id;
        }
        public string GetText(string metaTitle)
        {
            var item = db.SubMenus.SingleOrDefault(x => x.link == metaTitle);
            return item.text;
        }
    }
}
