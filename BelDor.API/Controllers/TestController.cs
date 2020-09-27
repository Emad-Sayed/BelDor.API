using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Helpers;
namespace BelDor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "ADMIN")]
    public class TestController : ControllerBase
    {
        [HttpGet("GetServerTime")]
        [AllowAnonymous]
        public ActionResult get()
        {
            var ServerDateTime = DateTime.Now.AddServerTimeHours();
            return Ok(ServerDateTime);
        }
    }
}
