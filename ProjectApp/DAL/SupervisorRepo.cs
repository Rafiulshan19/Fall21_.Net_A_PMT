using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupervisorRepo : IRepositoryS
    {
         PMAEntities2 db;

        public SupervisorRepo(PMAEntities2 db)
        {
            this.db = db;
        }

        public Supervisor Get(string email, string password)
        {
            var data = (from s in db.Supervisors
                        where s.Email == email && password == s.Password
                        select s).FirstOrDefault();
            return data;
        }

    }
}
