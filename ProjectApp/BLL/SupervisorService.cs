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
    public class SupervisorService
    {
        public static List<SupervisorModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Supervisor, SupervisorModel>();
                c.CreateMap<Member, MemberModel>();
            });
            var mapper = new Mapper(config);
            var da = DataAccess.SupervisorDataAcees();
            var data = mapper.Map<List<SupervisorModel>>(da.Get());
            return data;
        }
        public static List<string> GetNames()
        {
            var data = DataAccess.SupervisorDataAcees().Get().Select(e => e.Name).ToList();
            return data;
        }
        public static void Add(SupervisorModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<SupervisorModel, Supervisor>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Supervisor>(s);
            DataAccess.SupervisorDataAcees().Add(data);
        }
    }
}
