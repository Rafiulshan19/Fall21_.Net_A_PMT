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
        public static List<MemberModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Member, MemberModel>();
                //c.CreateMap<Member, MemberModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.MemberDataAccess();
            var data = mapper.Map<List<MemberModel>>(da.Get());
            return data;
        }
        public static List<string> GetNames()
        {
            var data = DataAccess.MemberDataAccess().Get().Select(e => e.Name).ToList();
            return data;
        }
        public static void Add(MemberModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MemberModel, Member>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Member>(s);
            DataAccess.MemberDataAccess().Add(data);
        }
    }
}
