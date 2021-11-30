using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepositoryManage
    {
        List<Member> OpenPM(int id);
        List<Member> ProgressingPM(int id);
        List<Member> CompletePM(int id);
    }
}
