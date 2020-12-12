using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public interface IVehicleDetailService
    {
        IEnumerable<VehicleDetailAllViewModel> All();

        void Create(VehicleDetailCreateViewModel model);

        void Edit(VehicleDetailEditViewModel model);

        VehicleDetailEditViewModel Details(int? id);

        void Delete(int? id);
    }
}
