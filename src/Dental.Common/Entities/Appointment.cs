using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dental.Common.Entities
{
    public class Appointment : IBaseEntity
    {
        [Key]
        public long AppointmentId { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentStartTime { get; set; }
        public string AppointmentEndTime { get; set; }
        public string Reason { get; set; }
        public bool IsActive { get; set; }
        public long PatientId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
