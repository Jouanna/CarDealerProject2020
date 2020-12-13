using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealerProject2020.Data.Models
{
    public class BuyerInfo
    {
        public BuyerInfo()
        {
            this.Deals = new HashSet<Deal>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(20)]
        public string City { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(10)]
        public string Phone { get; set; }

        [MaxLength(15)]
        public string DriverLicenseNumber { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }

    }
}
