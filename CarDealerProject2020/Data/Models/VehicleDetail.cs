using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealerProject2020.Data.Models
{
    public class VehicleDetail
    {
        public VehicleDetail()
        {
            this.Deals = new HashSet<Deal>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Details")]
        public int DetailsId { get; set; }
        public Detail Details { get; set; }

        [Required]
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }

    }
}
