using Dental.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Common.Repositories
{
    public interface ITreatmentRepository
    {
        Task<long> CreateTreatment(Treatment treatment);
    }
}
