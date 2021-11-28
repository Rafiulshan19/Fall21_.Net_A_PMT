using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class MemberModel
    {
        public int Id { get; set; }
        public int PId { get; set; }
        public int MId { get; set; }
        public int Sid { get; set; }
        public virtual Manage Manage { get; set; }
    }
}
