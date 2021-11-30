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
        
        public static IRepositoryS SupervisorDataAcees()
        {
            return new SupervisorRepo(db);
        }
        public static IRepositoryM MemberDataAccess()
        {
            return new MemberRepo(db);
        }
        
        public static IRepositoryP ProjectDataAccess()
        {
            return new ProjectRepo(db);
        }

    }
}
