using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarDealerProject2020.Data.Models
{
    public class Store
    {
        public Store()
        {
            this.SellersInfo = new HashSet<SellerInfo>();
            this.Cars = new HashSet<Detail>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string StoreName { get; set; }
        [Required]
        [MaxLength(20)]
        public string City { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        public virtual ICollection<SellerInfo> SellersInfo { get; set; }

        public virtual ICollection<Detail> Cars { get; set; }



    }
}
