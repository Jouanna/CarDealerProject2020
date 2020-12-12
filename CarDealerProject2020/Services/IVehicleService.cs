using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public interface IVehicleService
    {
        IEnumerable<VehicleAllViewModel> All();

        void Create(VehicleCreateViewModel model);

        void Edit(VehicleEditViewModel model);

        VehicleEditViewModel Details(int? id);

        void Delete(int? id);
    }
}
