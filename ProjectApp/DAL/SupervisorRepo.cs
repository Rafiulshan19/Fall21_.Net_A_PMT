using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupervisorRepo : Repository<Supervisor, int>
    {
        private PMAEntities2 db;

        public SupervisorRepo(PMAEntities2 db)
        {
            this.db = db;
        }

        public void Add(Supervisor e)
        {
            db.Supervisors.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var s = db.Supervisors.FirstOrDefault(e => e.Id == id);
            db.Supervisors.Remove(s);
            db.SaveChanges();
        }

        public void Edit(Supervisor e)
        {
            var s = db.Supervisors.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(s).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Supervisor> Get()
        {
            return db.Supervisors.ToList();
        }

        public Supervisor Get(int id)
        {
            return db.Supervisors.FirstOrDefault(e => e.Id == id);

        }
    }
}
