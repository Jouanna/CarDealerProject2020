using CarDealerProject2020.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDealerProject2020.Data.Models
{
    public class Detail
    {
        public Detail()
        {
            //this.VehiclesDetails = new HashSet<VehicleDetail>();
            this.Deals = new HashSet<Deal>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Range(1950, 2020)]
        public int Year { get; set; }

        [Required]
        public FuelType Fuel { get; set; }

        [Required]
        [Range(60, 500)]
        public int HorsePower { get; set; }
        public string Color { get; set; }

        [Required]
        [Range(1, 100000)]
        public decimal Price { get; set; }

        [ForeignKey("Store")]
        public int StoreId { get; set; }
        public Store Store { get; set; }

        [Required]
        [ForeignKey(nameof(Vehicle))]
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

        //public virtual ICollection<VehicleDetail> VehiclesDetails { get; set; }

        public virtual ICollection<Deal> Deals { get; set; }

    }
}
