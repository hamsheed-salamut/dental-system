using Dental.Common.Entities;
using Dental.Common.Repositories;
using Infrastructure.Persistence.Relational.Connection;
using Infrastructure.Persistence.Relational.Connection.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Relational.Repositories
{
    public class TreatmentRepository : BaseRepository<long, Treatment>, ITreatmentRepository
    {
        public TreatmentRepository(IConnectionFactory connectionFactory)
                : base(ConnectionSettingsConfiguration.Dental, connectionFactory)
        {

        }

        public async Task<long> CreateTreatment(Treatment treatment)
        {
            return await InsertAsync(treatment);
        }
    }
}
