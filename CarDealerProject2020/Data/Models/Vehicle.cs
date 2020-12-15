using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealerProject2020.Data.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            this.Details = new HashSet<Detail>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string BrandName { get; set; }

        public virtual ICollection<Detail> Details { get; set; }

    }
}
