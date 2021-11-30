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
    public class ProjectService
    {
        
        public static List<ProjectModel> OpenP()
        {
            var config = new MapperConfiguration(c =>
            
                c.CreateMap<Project, ProjectModel>()
                
            );
            var mapper = new Mapper(config);
            var da = DataAccess.ProjectDataAccess();
            var data = mapper.Map<List<ProjectModel>>(da.OpenP());
            return data;
        }
        public static List<ProjectModel> ProgressingP()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<Project, ProjectModel>()

            );
            var mapper = new Mapper(config);
            var da = DataAccess.ProjectDataAccess();
            var data = mapper.Map<List<ProjectModel>>(da.ProgressingP());
            return data;
        }
        public static List<ProjectModel> CompleteP()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<Project, ProjectModel>()

            );
            var mapper = new Mapper(config);
            var da = DataAccess.ProjectDataAccess();
            var data = mapper.Map<List<ProjectModel>>(da.CompleteP());
            return data;
        }

        public static void Add(ProjectModel p)
        {
            var config = new MapperConfiguration(c =>
            
                c.CreateMap<ProjectModel, Project>()

            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Project>(p);
            DataAccess.ProjectDataAccess().Add(data);
        }
    }
}
