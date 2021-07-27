using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.BAL;
using TicketingSystem.Models;
using System.Net.Http;

namespace TicketingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketDetailsController : ControllerBase
    {
        
        private readonly ILogger<TicketDetailsController> _logger;
        TicketLoggingBAL ticketLoggingBAL = new TicketLoggingBAL();


        public TicketDetailsController(ILogger<TicketDetailsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("ListTicketDetails")]
        public Task<List<TicketLogModel>> ListTicketDetails()
        {
            return ticketLoggingBAL.GetAllTickets();
        }

        [HttpGet]
        [Route("ListTicketDetailsById")]
        public TicketLogModel ListTicketDetailsById(Int64 Id)
        {
            return ticketLoggingBAL.GetAllTickets(Id);
        }
        [HttpGet]
        [Route("ListTicketCategory")]
        public List<TicketCategory> LoadTicketCategory()
        {
            return ticketLoggingBAL.LoadTicketCategory();
        }

        [HttpPost]
        [Route("SaveTicketDetails")]
        public Task<int> SaveTicketDetails(TicketLogModel ticketLogModel)
        {
          return ticketLoggingBAL.SaveTicketDetails(ticketLogModel);
        }

        [HttpPut]
        [Route("UpdateTicketDetails")]
        public Task<int> UpdateTicketDetails(TicketLogModel ticketLogModel)
        {
            return ticketLoggingBAL.UpdateTicketDetails(ticketLogModel);
        }

        [HttpDelete]
        [Route("DeleteTicketDetails")]
        public Task<int> DeleteTicketDetails(Int64 Id)
        {
            return ticketLoggingBAL.DeleteTicketDetails(Id);
        }
    }
}
