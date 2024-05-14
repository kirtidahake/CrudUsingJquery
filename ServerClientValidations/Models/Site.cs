using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServerClientValidations.Models
{
    public class Site
    {
        [Key]
        public int SiteId { get; set; }

        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }

        public string SiteName { get; set; }
    }
}