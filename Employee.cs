using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EMSProject.Models
{
    public class Employee
    {

        [Required(ErrorMessage = "Employee ID is Required")]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Age is Required")]
        public int Age { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Salary")]
        [Required(ErrorMessage = "Salary is Required")]
        [DataType(DataType.Currency)]
        public int Salary { get; set; }


    }
}
