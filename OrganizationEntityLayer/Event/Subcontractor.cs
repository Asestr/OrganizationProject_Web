using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationEntityLayer.Event
{
    public class Subcontractor
    {
        [Key]

        public int SubcontractorID { get; set; }
        public string SubcontractorMail { get; set; }
        public string SubcontractorName { get; set; }
        public string SubcontractorLastName { get; set; }
        public string SubcontractorPassword { get; set; }
        public string SubcontractorPasswordRepeat { get; set; }
        public bool SubcontractorLoginControl { get; set; }

      

    }
}
