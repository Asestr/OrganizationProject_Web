using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationEntityLayer.Event
{
    public class Company
    {
        [Key]
        public string OrganizerName { get; set; }
        public string OrganizerMail { get; set; }
        public string OrganizerLastName { get; set; }
        public string OrganizerPassword { get; set; }
        public string OrganizerPasswordRepeat { get; set; }
        public bool OrganizerLoginControl { get; set; }
        public ICollection<CompanyEvent> CompanyEvents
        {
            get; set;

        }
    }
}
