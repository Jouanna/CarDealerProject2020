using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.ViewModels
{
    public class VehicleEditViewModel
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "Марката на автомобила може да съдържа до 50 символа.")]
        [Required(ErrorMessage = "Необходимо е да въведете марка на автомобил.")]
        public string BrandName { get; set; }
    }
}
