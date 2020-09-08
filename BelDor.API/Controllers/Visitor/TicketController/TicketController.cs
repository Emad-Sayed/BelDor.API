using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BelDor.API.Helper;
using Core.Domain.ViewModel.Ticket;
using Core.Infrastrcture.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BelDor.API.Controllers.Visitor.TicketController
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private ITicketService service;
        public TicketController(ITicketService service_)
        {
            service = service_;
        }
        [Authorize(Roles = "VISITOR")]
        [HttpPost]
        public ActionResult TicketRequest(TicketRequestModel ticketRequestModel)
        {
            var response = service.TicketRequest(ticketRequestModel, User.GetUserId());
            if (response.status == true)
                return Ok(response);
            return BadRequest(response);
        }
        //[Authorize(Roles = "ADMIN")]
        [HttpGet]
        public ActionResult GetTickets([FromQuery]TicketSearchModel search)
        {
            var response = service.GetTicket(search);
            return Ok(response);
        }
        [Authorize(Roles = "EMPLOYEE")]
        [HttpGet("EmployeeDailyTickets")]
        public ActionResult EmployeeDailyTickets([FromQuery] TicketEmployeeSearchModel search)
        {
            int branchDepartementId = int.Parse(User.GetClaims("BranchDepartementId"));
            search.branchDepartementId = branchDepartementId;
            var response = service.EmployeeDailyTickets(search);
            return Ok(response);
        }
        [Authorize(Roles = "VISITOR")]
        [HttpGet("VisitorDailyTickets")]
        public ActionResult VisitorDailyTickets([FromQuery] TicketVisitorSearchModel search)
        {
            int visitorId = User.GetUserId();
            search.visitorId = visitorId;
            var response = service.VisitorDailyTickets(search);
            return Ok(response);
        }
    }
}
