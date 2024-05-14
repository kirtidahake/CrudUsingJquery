using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServerClientValidations.Models
{
    public class EmployeeDeptViewModel
    {
        public int EmployeeId { get; set; }


        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Enter Address")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Enter DepartmentId")]
        public int DepartmentId { get; set; }

        public string DName { get; set; }

        public string SiteName { get; set; }

    }
}