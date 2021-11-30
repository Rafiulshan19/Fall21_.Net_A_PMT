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
        public static SupervisorModel Get(Supervisor s)
        {
            var config = new MapperConfiguration(c =>
                c.CreateMap<Supervisor, SupervisorModel>()
           );
            var mapper = new Mapper(config);
           var data = mapper.Map<SupervisorModel>(DataAccess.SupervisorDataAcees().Get(s.Email, s.Password));
            return data;
        }
    }
}