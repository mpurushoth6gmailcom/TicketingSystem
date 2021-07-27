using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;

namespace TicketingSystem.DAL
{
    public class TicketLoggingDAL 
    {
        string connectionString = string.Empty;
        public TicketLoggingDAL(string _connectionString)
        {
            connectionString = _connectionString;
        }
        public async Task<List<TicketLogModel>> GetAllTickets()
        {
            try
            {
                var getTicketLog = "CREATE_USP_Ticket_Log_GET";
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    return (await db.QueryAsync<TicketLogModel>(getTicketLog,CommandType.StoredProcedure)).ToList();
                }
              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public List<TicketCategory> LoadTicketCategory()
        {
            try
            {
                using (IDbConnection db = new SqlConnection(connectionString))
                {
                   return db.Query<TicketCategory>("select * from Ticket_Category", null).ToList();
                }    
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public TicketLogModel GetTicketById(Int64 id)
        {
            try
            {
                TicketLogModel ticketLogModel = new TicketLogModel();
                var getTicketLog = "CREATE_USP_Ticket_Log_GET_BY_ID";

                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int64);

                using (IDbConnection db = new SqlConnection(connectionString))
                {
                    return db.Query<TicketLogModel>(getTicketLog, parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<int> SaveTicketDetails(TicketLogModel entity)
        {
            try
            {
                var CREATEUSPTicketLogINSERT = "CREATE_USP_Ticket_Log_INSERT";

                var parameters = new DynamicParameters();
                parameters.Add("Ticket_Title", entity.Ticket_Title, DbType.String);
                parameters.Add("Ticket_Description", entity.Ticket_Description, DbType.String);
                parameters.Add("Ticket_Category", entity.Ticket_Category, DbType.Int64);
                parameters.Add("Create_Date", entity.Create_Date, DbType.DateTime);

                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    return await connection.ExecuteAsync(CREATEUSPTicketLogINSERT, parameters, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<int> UpdateTicketDetails(TicketLogModel entity)
        {
            try
            {
                var CREATEUSPTicketLogUPDATE = "CREATE_USP_Ticket_Log_UPDATE";

                var parameters = new DynamicParameters();
                parameters.Add("Ticket_Title", entity.Ticket_Title, DbType.String);
                parameters.Add("Ticket_Description", entity.Ticket_Description, DbType.String);
                parameters.Add("Ticket_Category", entity.Ticket_Category, DbType.Int64);
                parameters.Add("Create_Date", entity.Create_Date, DbType.DateTime);
                parameters.Add("Ticket_Id", entity.Ticket_Id, DbType.Int64);
                

                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    return (await connection.ExecuteAsync(CREATEUSPTicketLogUPDATE, parameters, commandType: CommandType.StoredProcedure));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<int> DeleteTicketDetails(Int64 ticketId)
        {
            try
            {
                var CREATEUSPTicketLogDELETE = "CREATE_USP_Ticket_Log_DELETE";

                var parameters = new DynamicParameters();
                parameters.Add("Ticket_Id", ticketId, DbType.Int64);

                using (IDbConnection connection = new SqlConnection(connectionString))
                {
                    return (await connection.ExecuteAsync(CREATEUSPTicketLogDELETE, parameters, commandType: CommandType.StoredProcedure));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}
