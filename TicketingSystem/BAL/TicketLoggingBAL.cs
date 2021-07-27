using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.DAL;
using TicketingSystem.Models;

namespace TicketingSystem.BAL
{
    public class TicketLoggingBAL
    {
        TicketLoggingDAL TicketLoggingDAL = new TicketLoggingDAL("Data Source =.; Initial Catalog = TICKET_SYSTEM; Integrated Security = true");

        public TicketLoggingBAL() { }

        public Task<List<TicketLogModel>> GetAllTickets()
        {
            return TicketLoggingDAL.GetAllTickets();
        }

        public TicketLogModel GetAllTickets(Int64 Id)
        {
            return TicketLoggingDAL.GetTicketById(Id);
        }

        public List<TicketCategory> LoadTicketCategory()
        {
            return TicketLoggingDAL.LoadTicketCategory();
        }
        public Task<int> SaveTicketDetails(TicketLogModel entity)
        {
            return TicketLoggingDAL.SaveTicketDetails(entity);
        }

        public Task<int> UpdateTicketDetails(TicketLogModel entity)
        {
            return TicketLoggingDAL.UpdateTicketDetails(entity);
        }

        public Task<int> DeleteTicketDetails(Int64 TktId)
        {
            return TicketLoggingDAL.DeleteTicketDetails(TktId);
        }
    }
}
