using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Helpers;
using Hangfire;
using Microsoft.Extensions.Logging;
using Core.Domain.ViewModel.Lookups.Branch;
using Core.Domain.ViewModel;
using Core.Infrastrcture.Service;

namespace BelDor.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "ADMIN")]
    public class TestController : ControllerBase
    {
        private IService<BaseSearch, BranchCreateModel> service;
        public TestController(IService<BaseSearch, BranchCreateModel> service_)
        {
            service = service_;
        }
        [HttpGet("GetServerTime")]
        [AllowAnonymous]
        public ActionResult get()
        {
            var ServerDateTime = DateTime.Now.AddServerTimeHours();
            return Ok(ServerDateTime);
        }
        [AllowAnonymous]
        [HttpGet("QWE")]
        public ActionResult gett()
        {
            RecurringJob.AddOrUpdate(
    () => service.GetAll(new BaseSearch()),Cron.Daily(3)) ;
            return Ok();
        }
    }
}

// 10AM  12PM


