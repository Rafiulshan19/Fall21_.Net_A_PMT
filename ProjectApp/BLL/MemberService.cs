using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MemberService
    {
        public static MemberModel GetM(MemberModel m)
        {
            var config = new MapperConfiguration(c =>
            
                c.CreateMap<Member, MemberModel>()
            );
            var mapper = new Mapper(config);
             var data = mapper.Map<MemberModel>(DataAccess.MemberDataAccess().GetM(m.Email, m.Password));
            return data;
        }
       
    }
}
