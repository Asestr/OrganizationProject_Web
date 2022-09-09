
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationEntityLayer.Event
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventStartTime { get; set; }
        public DateTime EventRecourseOverTime { get; set; }
        public string EventExplanation { get; set; }
        public string EventAddress { get; set; }
        public int EventQuota { get; set; }
        public int EventCoin { get; set; }
        public bool EventTickedOrNotTicked { get; set; }
        public bool EventStatus { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int CityID { get; set; }
        public City City { get; set; }

        public int OrganizerID { get; set; }
        public Organizer Organizer { get; set; }

       
      



    }
}
