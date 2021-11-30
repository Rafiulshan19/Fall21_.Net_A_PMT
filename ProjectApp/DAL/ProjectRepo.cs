using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProjectRepo :IRepositoryP
    {
         PMAEntities2 db;

        public ProjectRepo(PMAEntities2 db)
        {
            this.db = db;
        }

        public void Add(Project p)
        {
            db.Projects.Add(p);
            db.SaveChanges();
        }
        
        public List<Project> ProgressingP()
        {
            var project = (from p in db.Projects
                           where p.Detail == "Progressing"
                           select p).ToList();
            return project;
        }
        public List<Project> OpenP()
        {
            var project = (from p in db.Projects
                           where p.Detail == "Open"
                           select p).ToList();
            return project;
        }
        public List<Project> CompleteP()
        {
            var project = (from p in db.Projects
                           where p.Detail == "Completed"
                           select p).ToList();
            return project;
        }
    }
}
//
