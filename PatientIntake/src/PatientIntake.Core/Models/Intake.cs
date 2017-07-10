using System;
using PatientIntake.Core.Enums;

namespace PatientIntake.Core.Models
{
    public class Intake
    {
        public int Id { get; set; }
        public Patient Patient { get; set; }
        public Address PatientAddress { get; set; }
        public string ImagesPath { get; set; }
        public IntakeType IntakeType { get; set; }
        public IntakeStatus Status { get; set; }
        public string Department { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? SyncedOn { get; set; }
    }
}
