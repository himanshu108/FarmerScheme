using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SixthAttempt.Models
{
    [Table("Admin")]
    public class Admin
    {
        public Admin()
        {
            this.farmersAdmin = new HashSet<Farmer>();
        }
        [Key]
        [Required]
        public int adminID { get; set; }
        [StringLength(12)]
        [Required]
        public string userName { get; set; }
        [StringLength(12)]
        [Required]
        public string password { get; set; }
        [StringLength(12)]
        [Required]
        public string contactDetails { get; set; }

        public virtual ICollection<Farmer> farmersAdmin { get; set; }
    }
}