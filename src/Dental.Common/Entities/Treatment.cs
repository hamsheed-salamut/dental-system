using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dental.Common.Entities
{
    public class Treatment : IBaseEntity
    {
        [Key]
        public long TreatmentId { get; set; }
        public string Description { get; set; }
        public string Diagnosis { get; set; }
        public string XrayImagePath { get; set; }
        public string ConsentFormPath { get; set; }
        public long PatientId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
