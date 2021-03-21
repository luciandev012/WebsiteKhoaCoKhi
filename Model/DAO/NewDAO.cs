using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.EF;
using PagedList;

namespace Model.DAO
{
    public class NewDAO
    {
        WebsiteKhoaCoKhiDbContext db = null;

        public NewDAO()
        {
            db = new WebsiteKhoaCoKhiDbContext();
        }
        public int Insert(New entity)
        {
            //entity.createdDate = DateTime.Now;

            db.News.Add(entity);
            db.SaveChanges();
            return entity.id;
        }
        
        public IEnumerable<New> listAll(string searchString, int page, int pageSize)
        {
            IQueryable<New> model = db.News.OrderBy(x => x.id);
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.name.Contains(searchString) || x.content.Contains(searchString)); 
            }
            return model.OrderBy(x => x.id).ToPagedList(page, pageSize); 
        }

        public IEnumerable<New> listAllByType(int cateId, int page, int pageSize)
        {
            IQueryable<New> model = db.News.Where(x => x.categoryId == cateId).OrderBy(x => x.id);
            
            return model.OrderBy(x => x.id).ToPagedList(page, pageSize);
        }

        public object GetLastestNotice(int count)
        {
            return db.News.Where(x => x.categoryId == 2).OrderByDescending(x => x.createdDate).Take(count).ToList();
        }

        public List<New> GetLastestNew(int v)
        {
            return db.News.Where(x => x.categoryId == 4).OrderByDescending(x => x.createdDate).Take(v).ToList();
        }

        public List<New> ListHighLigtNew()
        {
            return db.News.OrderBy(x => x.title).Take(10).ToList();
        }

        public bool Update(New entity)
        {
            try
            {
                var anew = db.News.Find(entity.id);
                anew.name = entity.name;
                anew.content = entity.content;
                anew.title = entity.title;
                anew.modifyDate = DateTime.Now;
                anew.modifyBy = entity.modifyBy;
                anew.images = entity.images;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
        public New FindById(int id)
        {
            return db.News.Find(id);
        }
        public bool Delete(int id)
        {
            try
            {
                var anew = db.News.Find(id);
                db.News.Remove(anew);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public New GetNewByMetaTitle(string metaTitle)
        {
            return db.News.SingleOrDefault(x => x.metaTitle == metaTitle);
        }
        public void UpdateView(string metaTitle)
        {
            New entity = db.News.SingleOrDefault(x => x.metaTitle == metaTitle);
            if(entity.newView == null)
            {
                entity.newView = 1;
            }
            else
            {
                entity.newView += 1;
            }
            db.SaveChanges();
        }
    }
}
