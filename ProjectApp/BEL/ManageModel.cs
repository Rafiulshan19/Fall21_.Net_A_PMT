using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ManageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual MemberModel MemberModel { get; set; }
        public virtual SupervisorModel SupervisorModel { get; set; }
        public virtual ProjectModel ProjectModel { get; set; }
    }
}
