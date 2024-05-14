using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServerClientValidations.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

    
        public string Name { get; set; }

      
        public string Address { get; set; }

        public Department Department { get; set; }

        public int DepartmentId { get; set; }

        public bool IsDeleted { get; set; }
    }
}