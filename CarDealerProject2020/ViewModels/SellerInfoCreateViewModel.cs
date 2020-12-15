using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class SellerInfoCreateViewModel
    {
        [MaxLength(100)]
        [Required(ErrorMessage = "Необходимо е да въведете марка на автомобил.")]
        public string Name { get; set; }
        public int StoreId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> Stores { get; set; }
    }
}
