using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Model
{
    public class StudentInfo
    {
        public int id { get; set; }
        [Required]
        public int departmentId { get; set; }
        [Required]
        public string courseName { get; set; }

        public string email { get; set; }
        public string sportsName { get; set; }


    }
}
