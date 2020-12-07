using CarDealerProject2020.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class DetailAllViewModel
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }
        public FuelType Fuel { get; set; }

        public int HorsePower { get; set; }
        public string Color { get; set; }

        public decimal Price { get; set; }

        public int StoreId { get; set; }
    }
}
