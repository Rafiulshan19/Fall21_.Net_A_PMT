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
    public class MemberController : ApiController
    {
        [Route("api/Member/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return MemberService.GetNames();
        }
        [Route("api/Member/All")]
        [HttpGet]
        public List<MemberModel> GetAll()
        {
            return MemberService.Get();
        }
        [Route("api/Member/Create")]
        [HttpPost]
        public void Add(MemberModel s)
        {
            MemberService.Add(s);
        }
    }
}
