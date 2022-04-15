using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SixthAttempt.Models
{

    [Table("CropList")]
    public class CropList
    {
        public CropList()
        {
            this.farmers = new HashSet<Farmer>();
        }
        [Key]
        [Required]
        public int cropID { get; set; }
        [StringLength(15)]
        [Required]
        public string cropName { get; set; }
        [StringLength(15)]
        [Required]
        public string cropType { get; set; }
        [Required]
        public int cropQuantity { get; set; }
        [Required]
        public double basePrice { get; set; }
        [Required]
        public double sellPrice { get; set; }

        public virtual ICollection<Farmer> farmers { get; set; }
    }
}