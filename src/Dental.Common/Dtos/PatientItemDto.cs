using System;
using System.Collections.Generic;
using System.Text;

namespace Dental.Common.Dtos
{
    public class PatientItemDto
    {
        public long PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public string Reason { get; set; }
        public string Phone { get; set; }
    }
}
