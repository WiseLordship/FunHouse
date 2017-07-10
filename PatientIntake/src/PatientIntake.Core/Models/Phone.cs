using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatientIntake.Core.Enums;

namespace PatientIntake.Core.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public PhoneType Type { get; set; }
        public int Number { get; set; }
        public Ordinality Ordinality { get; set; }
    }
}
