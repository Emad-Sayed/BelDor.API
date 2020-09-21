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
        private IResponse modelStateResponse;

        public BranchController(IService<BaseSearch, BranchCreateModel> service_, IResponse modelStateResponse_)
        {
            service = service_;
            modelStateResponse = modelStateResponse_;
        }
        [HttpPost]
        public ActionResult AddBranch(BranchCreateModel branch)
        {
            if (!ModelState.IsValid)
            {
                modelStateResponse.status = false;
                modelStateResponse.error_EN = String.Join("&&", ModelState.Values.SelectMany(e => e.Errors.Select(e => e.ErrorMessage)));
                return BadRequest(modelStateResponse);
            }
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