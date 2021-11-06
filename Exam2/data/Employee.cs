using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exam2.data
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        public DateTime BDate { get; set; }

        public int Phone { get; set; }

        [ForeignKey("country")]
        public int Country_ID { get; set; }
        public Country country { get; set; }

        public string profilePic { get; set; }

        [NotMapped]
        public IFormFile ProfilePic { get; set; }

    }
}
