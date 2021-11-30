using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ProjectApp.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProjectController : ApiController
    {
        [Route("api/projects/add")]
        [HttpPost]
        public void Add(ProjectModel p)
        {
            ProjectService.Add(p);
        }

        [Route("api/Projects/OpenP")]
        [HttpPost]
        public List<ProjectModel>OpenP()
        {
            return ProjectService.OpenP();
        }

        [Route("api/Projects/ProgressingP")]
        [HttpPost]
        public List<ProjectModel> ProgressingP()
        {
            return ProjectService.ProgressingP();
        }

        [Route("api/Projects/CompleteP")]
        [HttpPost]
        public List<ProjectModel> CompleteP()
        {
            return ProjectService.CompleteP();
        }
    }
}
