using CarDealerProject2020.Data.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class DetailCreateViewModel
    {
        [Required(ErrorMessage = "Необходимо е да въведете тип на автомобила.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Необходимо е да въведете модел на автомобила.")]
        public string Model { get; set; }


        [Required(ErrorMessage = "Необходимо е да въведете година на автомобила.")]
        [Range(1950, 2020, ErrorMessage = "Годината на автомобила може да бъде между 1950 и 2020.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Необходимо е да въведете гориво на автомобила.")]
        public FuelType Fuel { get; set; }

        [Required(ErrorMessage = "Необходимо е да въведете мощност на автомобила.")]
        [Range(60, 500, ErrorMessage = "Мощността на автомобила може да бъде между 60 и 500 к.с.")]
        public int HorsePower { get; set; }

        public string Color { get; set; }

        [Required(ErrorMessage = "Необходимо е да въведете цена на автомобила.")]
        [Range(1, 100000, ErrorMessage = "Цената на автомобила може да бъде до 100 000 лв.")]
        public decimal Price { get; set; }

        public int StoreId { get; set; }
        public int VehicleId { get; set; }

        public string StoreName { get; set; }
        public string BrandName { get; set; }

        public IEnumerable<KeyValuePair<string,string>> Stores { get; set; }
        public IEnumerable<KeyValuePair<string,string>> Vehicles { get; set; }
    }
}
