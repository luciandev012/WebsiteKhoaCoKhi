using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class AdminAccountDAO
    {
        WebsiteKhoaCoKhiDbContext db = null;

        public AdminAccountDAO()
        {
            db = new WebsiteKhoaCoKhiDbContext();
        }

        public long Insert(AdminAccount entity)
        {
            db.AdminAccounts.Add(entity);
            db.SaveChanges();
            return entity.id;
        }
        public int Login(string username, string password)
        {
            var rs = db.AdminAccounts.SingleOrDefault(x => x.userName == username);
            if (rs == null)
            {
                return 0;
            }
            else
            {
                if (rs.status == false)
                {
                    return -1;
                }
                else
                {
                    if(rs.password == password)
                    {
                        return 1;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }

        }
        public AdminAccount GetAdminByUserName(string username)
        {
            return db.AdminAccounts.SingleOrDefault(x => x.userName == username);
        }
    }
}
