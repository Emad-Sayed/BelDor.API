using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.ViewModel.Access;
using Core.Infrastrcture.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelDor.API.Controllers.AuthController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService service;
        public UserController(IUserService service_)
        {
            service = service_;
        }
        [HttpPost("CreateVisistor")]
        public async Task<ActionResult> CreateVisistor(RegisterationModel visitor)
        {
            var response = await service.CreateVisitor(visitor);
            if (response.status == true)
                return Ok(response);
            return BadRequest(response);
        }
        [HttpPost("CreateManagerOrEmployee")]
        public async Task<ActionResult> CreateManagerOrEmployee(AddManagerOrEmployee clerk)
        {
            var response = await service.CreateManagerOrEmployee(clerk);
            if (response.status == true)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
