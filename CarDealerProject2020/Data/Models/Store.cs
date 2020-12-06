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
        public string StoreName { get; set; }
        [Required]
        public string City { get; set; }

        public string Address { get; set; }

        public virtual ICollection<SellerInfo> SellersInfo { get; set; }

        public virtual ICollection<Detail> Cars { get; set; }



    }
}
