using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class BuyerInfoCreateViewModel
    {
        [MaxLength(100)]
        [Required(ErrorMessage = "Необходимо е да въведете име.")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string MiddleName { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Необходимо е да въведете фамилия.")]
        public string LastName { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Необходимо е да въведете населено място.")]
        public string City { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(10)]
        public string Phone { get; set; }

        [MaxLength(15)]
        public string DriverLicenseNumber { get; set; }

    }
}
