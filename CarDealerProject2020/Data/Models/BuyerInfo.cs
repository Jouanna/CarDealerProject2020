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
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string DriverLicenseNumber { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }

    }
}
