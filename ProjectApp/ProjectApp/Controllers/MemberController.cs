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
    public class MemberController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [Route("api/Members/login")]
        [HttpPost]
        public MemberModel Login(MemberModel m)
        {
            return MemberService.GetM(m);
        }
    }
}
