using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Model
{
    public class Student
    {

        public int id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string name { get; set; }
        [Required]
        [DisplayName("Registration No")]
        public string registrationNo { get; set; }
        [Required]
        [DisplayName("Address")]
        public string address { get; set; }
        [Required]
        [DisplayName("Mobile No")]
        public string mobileNo { get; set; }

    }
}
