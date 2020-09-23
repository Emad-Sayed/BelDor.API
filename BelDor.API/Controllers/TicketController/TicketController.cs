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

namespace BelDor.API.Controllers.TicketController
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
        public ActionResult GetTickets([FromQuery] TicketSearchModel search)
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
        [Authorize(Roles = "EMPLOYEE")]
        [HttpPost("ServeTicket")]
        public ActionResult ServeTicket()
        {
            int branchDepartementId = int.Parse(User.GetClaims("BranchDepartementId"));
            int employeeId = User.GetUserId();
            var response = service.ServeTicket(new TicketServingModel { BranchDepartementId = branchDepartementId, EmployeeId = employeeId });
            return Ok(response);
        }
        [Authorize(Roles = "EMPLOYEE")]
        [HttpPost("CloseServedTicket")]
        public ActionResult CloseServedTicket(string Information)
        {
            int branchDepartementId = int.Parse(User.GetClaims("BranchDepartementId"));
            int employeeId = User.GetUserId();
            var response = service.CloseServedTicket(new TicketClosedModel { BranchDepartementId = branchDepartementId, EmployeeId = employeeId, Information = Information });
            return Ok(response);
        }

        [Authorize(Roles = "EMPLOYEE")]
        [HttpPost("SetTicketAsMissed")]
        public ActionResult SetTicketAsMissed()
        {
            int branchDepartementId = int.Parse(User.GetClaims("BranchDepartementId"));
            int employeeId = User.GetUserId();
            var response = service.SetTicketAsMissed(new TicketClosedModel { BranchDepartementId = branchDepartementId, EmployeeId = employeeId });
            return Ok(response);
        }

        [Authorize(Roles = "EMPLOYEE")]
        [HttpPost("ServeMissedTicket")]
        public ActionResult ServeMissedTicket([FromQuery]int ticketId)
        {
            int branchDepartementId = int.Parse(User.GetClaims("BranchDepartementId"));
            int employeeId = User.GetUserId();
            var response = service.ServeMissedTicket(new TicketServeMissedModel { TicketId = ticketId, BranchDepartementId = branchDepartementId, EmployeeId = employeeId });
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

        //[Authorize]
        [HttpGet("ClosedTicketInfo{id}")]
        public ActionResult ClosedTicketInfo(int id)
        {
            var response = service.ClosedTicketInfo(id);
            if (!response.status)
                return NotFound(response);
            return Ok(response);
        }
    }
}
