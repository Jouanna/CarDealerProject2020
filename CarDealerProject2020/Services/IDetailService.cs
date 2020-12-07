using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public interface IDetailService
    {
        IEnumerable<DetailAllViewModel> All();

        void Create(DetailCreateViewModel model);

        void Edit(DetailEditViewModel model);

        DetailEditViewModel Details(int? id);

        void Delete(int? id);
    }
}
