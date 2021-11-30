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
    [EnableCors("*","*","*")]
    public class SupervisorController : ApiController
    {
        [Route("api/Supervisors/login")]
        [HttpPost]
        public SupervisorModel Login(SupervisorModel s)
        {
            return SupervisorService.Get(s);
        }

    }
}
