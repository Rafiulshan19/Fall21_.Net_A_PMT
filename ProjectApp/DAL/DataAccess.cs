using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        static PMAEntities2 db;
        static DataAccess()
        {
            db = new PMAEntities2();
        }
        
        public static Repository<Supervisor, int> SupervisorDataAcees()
        {
            return new SupervisorRepo(db);
        }
        public static Repository<Member, int> MemberDataAccess()
        {
            return new MemberRepo(db);
        }
        
    }
}
