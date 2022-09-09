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
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyrMail { get; set; }
       
        public string CompanyPassword { get; set; }
        public string CompanyPasswordRepeat { get; set; }
        public bool CompanyLoginControl { get; set; }
       
    }
}
