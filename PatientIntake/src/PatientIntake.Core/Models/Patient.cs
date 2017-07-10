using System;

namespace PatientIntake.Core.Models
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DisplayFullName => FirstName + " " + MiddleName + " " + LastName;
        public string FormalFullName => LastName + ", " + FirstName + " " + MiddleName;
        public int Age
        {
            get
            {
                var timeDifference = DateTime.Now - DateTime.MinValue;
                return timeDifference.Hours / 24;
            }
        }
    }
}
