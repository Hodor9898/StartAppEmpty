using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Web;
using System.Web.Http;
using StarTeam.Models;
using StarTeam.Server.Server_Logic;

namespace StarTeam.Controllers
{
    public class UserController : ApiController
    {
        public IHttpActionResult IsUserExists(User user)
        {
            return Ok(UserControllerLogic.IsUserExists(user));
        }
    }
}