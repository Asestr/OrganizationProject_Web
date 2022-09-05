using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationEntityLayer.Event
{
    public class Admin
    {
        [Key]
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }

        public List<Event> Events { get; set; }
    }
}
