using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace api.persistance.ConnectionProvider
{
    public interface IConnectionProvider 
    {
        SqlConnection GetConnection();
    }
    public class ConnectionProvider : IConnectionProvider
    {
        private readonly IConfiguration _configuration;
        public ConnectionProvider(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public SqlConnection GetConnection() {
            var conn = _configuration.GetConnectionString("AppDB");
            SqlConnection connection = new SqlConnection(conn);
            return connection;
        }
        
    }
}
