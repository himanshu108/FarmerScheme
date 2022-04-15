using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SixthAttempt.Models
{
    [Table("Insurence")]
    public class Insurence
    {
        [Key]
        [Required]
        public int companyID { get; set; }
        [Required]
        [StringLength(12)]
        public string companyName { get; set; }
        [StringLength(12)]
        [Required]
        public string city { get; set; }
        [StringLength(12)]
        [Required]
        public string ownerOfCompany { get; set; }

    }
}