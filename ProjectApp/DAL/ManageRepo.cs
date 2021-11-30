using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManageRepo:IRepositoryManage
    {
        public PMAEntities2 db;
        public ManageRepo(PMAEntities2 db)
        {
            this.db = db;
        }

        public List<Member> CompletePM(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> OpenPM(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> ProgressingPM(int id)
        {
            throw new NotImplementedException();
        }
    }
}
