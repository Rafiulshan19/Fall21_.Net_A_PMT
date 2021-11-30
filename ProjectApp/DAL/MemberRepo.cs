using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class MemberRepo :IRepositoryM
    {
         PMAEntities2 db;

        public MemberRepo(PMAEntities2 db)
        {
            this.db = db;
        }
        public Member GetM(string email, string password)
        {
            var data = (from m in db.Members
                        where m.Email == email && password == m.Password
                        select m).FirstOrDefault();
             return data;
        }
    }
}
