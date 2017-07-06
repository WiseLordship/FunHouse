using System;

namespace PatientIntake.Core.Models
{
    public class SystemInformation
    {
        public string Name { get; set; }
        public string IpAddress { get; set; }
        public DateTimeOffset Time { get; set; }
    }
}