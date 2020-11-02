using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace Infrastructure.Persistence.Relational.Connection
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public ConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetDbConnection(DatabaseConnection connectionSetting)
        {
            switch (connectionSetting.DatabaseType)
            {
                case DatabaseType.Sql:
                    SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLServer);
                    return new SqlConnection(connectionSetting.ConnectionKey);
                default:
                    throw new ArgumentOutOfRangeException(nameof(connectionSetting.DatabaseType), connectionSetting.DatabaseType, null);
            }
        }
    }
}
