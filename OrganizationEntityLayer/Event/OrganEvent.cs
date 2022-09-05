
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationEntityLayer.Event
{
    public class OrganEvent
    {
        [ForeignKey("Event")]
        public int EventId { get; set; }

        [ForeignKey("Organizer")]
        public string OrganizerMail { get; set; }

        
        public Event Event { get; set; }
        public Organizer Organizer { get; set; }
    }
}
