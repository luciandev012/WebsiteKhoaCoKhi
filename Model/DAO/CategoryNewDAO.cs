using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class CategoryNewDAO
    {
        WebsiteKhoaCoKhiDbContext db = null;
        
        public CategoryNewDAO()
        {
            db = new WebsiteKhoaCoKhiDbContext();
        }
        public List<CategoryNew> ListAll()
        {
            return db.CategoryNews.ToList();
        }
        public string GetCategoryNew(int? id)
        {
            CategoryNew category = db.CategoryNews.Find(id);
            return category.name;
        }
        public string GetCategoryMetaTitle(int id)
        {
            CategoryNew category = db.CategoryNews.Find(id);
            return category.metaTitle;
        }
        public int GetCategoryId(string metaTitle)
        {
            return db.CategoryNews.SingleOrDefault(x => x.metaTitle == metaTitle).id;
        }
    }
}
