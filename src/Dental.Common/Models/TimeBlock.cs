using System;
using System.Collections.Generic;
using System.Text;

namespace Dental.Common.Models
{
    public class TimeBlock
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime Today { get; set; }
    }

    public class TimeSlots
    {
        public TimeSlots()
        {
            UsedSlots = new List<string>();
            AvailableSlots = new List<string>();
        }

        public List<string> UsedSlots { get; set; }
        public List<string> AvailableSlots { get; set; }
    }
}
