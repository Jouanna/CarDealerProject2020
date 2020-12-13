using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class VehicleDetailCreateViewModel
    {
        public int DetailId { get; set; }
        public int VehicleId { get; set; }

        public string BrandName { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Fuel { get; set; }
        public string HorsePower { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
        public string StoreId { get; set; }
    }
}
