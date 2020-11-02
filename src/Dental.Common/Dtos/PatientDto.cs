using Dental.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dental.Common.Dtos
{
    public class PatientDto
    {
        public Patient Patients { get; set; }
        public Treatment Treatments { get; set; }
    }
}
