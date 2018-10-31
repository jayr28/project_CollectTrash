using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollectTrash.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }
   
        public string EmailAddress { get; set; }
        public DateTime? PickUpDate { get; set; }

        public DateTime? ExtraPickUpDate { get; set; }
        public double Balance { get; set; }
       

    }
}