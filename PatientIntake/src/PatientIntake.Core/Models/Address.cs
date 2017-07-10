using System;
using PatientIntake.Core.Enums;

namespace PatientIntake.Core.Models
{
    public class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string ApartmentNumber { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public Ordinality Ordinality { get; set; }
        //TODO: Add conditionals to ensure addres looks right.
        public string DisplayAddress => AddressLine1 + Environment.NewLine +
                                        AddressLine2 + Environment.NewLine +
                                        City + ", " + State + " " + ZipCode + Environment.NewLine;
    }
}
