using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollectTrash.Models
{
    public class ZipCode
    {
        [Key]
        public int ID { get; set; }
        public int PostalCode { get; set; }
    }
}