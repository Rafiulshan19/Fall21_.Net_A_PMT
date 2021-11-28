using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class MemberRepo : Repository<Member, int>
    {
        private PMAEntities2 db;

        public MemberRepo(PMAEntities2 db)
        {
            this.db = db;
        }

        public void Add(Member e)
        {
            db.Members.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.Members.FirstOrDefault(en => en.Id == id);
            db.Members.Remove(e);
            db.SaveChanges();
        }

        public void Edit(Member e)
        {
            var m = db.Members.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(m).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Member> Get()
        {
            return db.Members.ToList();
        }

        public Member Get(int id)
        {
            return db.Members.FirstOrDefault(e => e.Id == id);
        }
    }
}
