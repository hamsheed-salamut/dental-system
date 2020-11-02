using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Relational.Connection.Configuration
{
    public static class ConnectionSettingsConfiguration
    {
        public static ConnectionSettings Dental => new ConnectionSettings
        {
            Connection = new DatabaseConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hamsheed.Salamut\source\repos\dental-management-system\src\Infrastructure\Persistence\Relational\DatabaseFile\DentalDB.mdf;Integrated Security=True;Connect Timeout=30", DatabaseType.Sql)
        };
    }
}
