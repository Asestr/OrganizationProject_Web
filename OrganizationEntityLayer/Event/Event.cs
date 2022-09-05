
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
        public bool EventTickedOrNotTicked { get; set; }

        [ForeignKey("Category")]
        public string CategoryName { get; set; }
        public Category Categorys { get; set; }

        [ForeignKey("City")]
        public string CityName { get; set; }
        public City Citys { get; set; }

        [ForeignKey("Admin")]
        public string Admin { get; set; }
        public Admin Admins { get; set; }

       

        public ICollection<SubconEvent> SubconEvents { get; set; }
        public ICollection<OrganEvent> OrganEvents { get; set; }
        public ICollection<CompanyEvent> CompanyEvents
        {
            get; set;

        }

        
    }
}
