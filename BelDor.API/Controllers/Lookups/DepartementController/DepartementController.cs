using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.ViewModel;
using Core.Domain.ViewModel.Lookups.Departement;
using Core.Infrastrcture.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelDor.API.Controllers.Lookups.DepartementController
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartementController : ControllerBase
    {
        private IService<BaseSearch, DepartementCreateModel> service;

        public DepartementController(IService<BaseSearch, DepartementCreateModel> service_)
        {
            service = service_;
        }
        [HttpPost]
        public ActionResult AddDepartement(DepartementCreateModel departement)
        {
            var response = service.Create(departement);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult GetDepartements([FromQuery] BaseSearch search)
        {
            var response = service.GetAll(search);
            return Ok(response);
        }
        [HttpGet("{id}")]
        public ActionResult GetDepartementById(int id)
        {
            var response = service.GetById(id);
            if (!response.status)
                return NotFound(response);
            return Ok(response);
        }
    }
}
