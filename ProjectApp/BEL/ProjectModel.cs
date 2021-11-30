using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        //public virtual Manage Manage { get; set; }
    }
}
