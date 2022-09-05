using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationEntityLayer.Event
{
    public class SubconEvent
    {
        [ForeignKey("Event")]
        public int EventId { get; set; }

        [ForeignKey("Subcontractor")]
        public string SubcontractorMail { get; set; }

        public Event Event { get; set; }
        public Subcontractor Subcontractor { get; set; }


    }
}
