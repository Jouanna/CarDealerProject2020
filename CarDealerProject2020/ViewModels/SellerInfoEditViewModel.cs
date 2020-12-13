using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class SellerInfoEditViewModel
    {
        public int Id { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Необходимо е да въведете марка на автомобил.")]
        public string Name { get; set; }
        public int StoreId { get; set; }

        public string StoreName { get; set; }
    }
}
