using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealerProject2020.Data.Models
{
    public class Vehicle
    {
        public Vehicle()
        {
            this.VehiclesDetails = new HashSet<VehicleDetail>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string BrandName { get; set; }

        public virtual ICollection<VehicleDetail> VehiclesDetails { get; set; }

    }
}
