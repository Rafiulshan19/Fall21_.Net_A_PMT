using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectApp.Controllers
{
    public class SupervisorController : ApiController
    {
        [Route("api/Supervisor/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return SupervisorService.GetNames();
        }
        [Route("api/Supervisor/All")]
        [HttpGet]
        public List<SupervisorModel> GetAll()
        {
            return SupervisorService.Get();
        }
        [Route("api/Student/Create")]
        [HttpPost]
        public void Add(SupervisorModel s)
        {
            SupervisorService.Add(s);
        }
    }
}
