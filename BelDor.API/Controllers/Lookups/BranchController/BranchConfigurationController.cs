using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelDor.API.Helper;
using Core.Domain.ViewModel.Configuration;
using Core.Infrastrcture.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelDor.API.Controllers.BranchConfiguration
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchConfigurationController : ControllerBase
    {
        private IBranchConfiguration service;

        public BranchConfigurationController(IBranchConfiguration service_)
        {
            service = service_;
        }
        [Authorize(Roles = "MANAGER")]
        [HttpPost("SetBranchTime")]
        public ActionResult SetBranchTime(BranchWorkingTimeModel config)
        {
            int BranchId = int.Parse(User.GetClaims("BranchId"));
            var response = service.SetBranchTime(config,User.GetUserId(), BranchId);
            return Ok(response);
        }
        [Authorize(Roles = "MANAGER")]
        [HttpPost("GetBackToDefaultTime")]
        public ActionResult GetBackToDefaultTime()
        {
            int BranchId = int.Parse(User.GetClaims("BranchId"));
            var response = service.GetBackToDefaultTime(BranchId);
            return Ok(response);
        }
        [Authorize(Roles = "MANAGER")]
        [HttpGet("GetMyBranchTime")]
        public ActionResult GetMyBranchTime()
        {
            int BranchId = int.Parse(User.GetClaims("BranchId"));
            var response = service.GetBranchTime(BranchId);
            return Ok(response);
        }
        [Authorize(Roles = "ADMIN")]
        [HttpPost("ForceSetBranchTime")]
        public ActionResult ForceSetBranchTime(ForceBranchWorkingTimeModel config)
        {
            var response = service.SetBranchTime(config, User.GetUserId(),config.BranchId);
            return Ok(response);
        }
        [Authorize(Roles = "ADMIN")]
        [HttpPost("ForceGetBackToDefaultTime")]
        public ActionResult ForceGetBackToDefaultTime(int BranchId)
        {
            var response = service.GetBackToDefaultTime(BranchId);
            return Ok(response);
        }

        //[Authorize(Roles = "ADMIN")]
        [HttpGet("GetBranchTime")]
        public ActionResult GetBranchTime([FromQuery]int BranchId)
        {
            var response = service.GetBranchTime(BranchId);
            return Ok(response);
        }

    }
}
