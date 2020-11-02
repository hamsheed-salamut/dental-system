using System;
using System.Collections.Generic;
using System.Text;

namespace Dental.Common.Entities
{
    public interface IBaseEntity
    {
        DateTime? CreatedDate { get; set; }
        DateTime? ModifiedDate { get; set; }
    }
}
