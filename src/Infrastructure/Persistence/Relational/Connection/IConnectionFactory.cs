using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Infrastructure.Persistence.Relational.Connection
{
    public interface IConnectionFactory
    {
        IDbConnection GetDbConnection(DatabaseConnection connectionSetting);
    }
}
