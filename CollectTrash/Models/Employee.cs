using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollectTrash.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId{get; set;}
        public ApplicationUser ApplicationUser { get; set; }
        public string EmailAddress { get; set; }
        public string ListNames { get; set;  }
        public int Zipcode { get; set; }
        public DateTime PickupDates { get; set; }
        public double Balance { get; set; }
        public string Status { get; set; }

    }
}