
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationEntityLayer.Event
{
    public class CompanyEvent
    {
        [ForeignKey("Event")]
        public int EventId { get; set; }

        [ForeignKey("Company")]
        public string CompanyName { get; set; }

        public Event Event { get; set; }
        public Company Organizer
        {
            get; set;
        }
    }
}
