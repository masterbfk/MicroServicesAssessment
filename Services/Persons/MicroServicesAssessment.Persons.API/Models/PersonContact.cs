using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServicesAssessment.Persons.API.Models
{
    public class PersonContact
    {
        public Guid ContactId { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
    }
}
