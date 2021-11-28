using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class SupervisorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual Manage Manage { get; set; }

    }
}
