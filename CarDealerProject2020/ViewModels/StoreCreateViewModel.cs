using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class StoreCreateViewModel
    {
        [MaxLength(50, ErrorMessage = "Името на магазина може да съдържа до 50 символа.")]
        [Required(ErrorMessage = "Необходимо е да въведете име на магазина.")]
        public string StoreName { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Необходимо е да въведете населено място.")]
        public string City { get; set; }

        [MaxLength(200, ErrorMessage = "Адресът може да съдържа до 50 символа.")]
        [Required(ErrorMessage = "Необходимо е да въведете адрес на магазина.")]
        public string Address { get; set; }
    }
}
