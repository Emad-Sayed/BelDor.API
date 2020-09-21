using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Branch;
using Core.Infrastrcture.Service;
using Infrastructure.Service.Lookups;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelDor.API.Controllers.Lookups.BranchController
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private IService<BaseSearch, BranchCreateModel> service;

        public BranchController(IService<BaseSearch, BranchCreateModel> service_)
        {
            service = service_;
        }
        [HttpPost]
        public ActionResult AddBranch(BranchCreateModel branch)
        {
            var response = service.Create(branch);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetBranches([FromQuery] BaseSearch search)
        {
            var response = service.GetAll(search);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetBrancheById(int id)
        {
            var response = service.GetById(id);
            if (!response.status)
                return BadRequest(response);
            return Ok(response);
        }
    }
}