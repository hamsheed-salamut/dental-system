using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Relational.Connection
{
    public class DatabaseConnection
    {
        public string ConnectionKey { get; }
        public DatabaseType DatabaseType { get; }

        public DatabaseConnection(string connectionKey, DatabaseType databaseType)
        {
            ConnectionKey = connectionKey;
            DatabaseType = databaseType;
        }
    }
}
