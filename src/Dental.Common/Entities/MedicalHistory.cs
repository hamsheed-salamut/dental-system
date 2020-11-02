using System;
using System.Collections.Generic;
using System.Text;

namespace Dental.Common.Entities
{
    public class MedicalHistory
    {
        public long MedicalHistoryId { get; set; }
        public string HealthNotes { get; set; }
        public string Allergy { get; set; }
        public long PatientId { get; set; }
    }
}
