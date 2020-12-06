using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealerProject2020.Data.Models
{
    public class SellerInfo
    {

        public SellerInfo()
        {
            this.Deals = new HashSet<Deal>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Stores")]
        public int StoreId { get; set; }
        public Store Stores { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }

    }
}
