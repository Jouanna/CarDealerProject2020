using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public interface IBuyerInfoService
    {
        IEnumerable<BuyerInfoAllViewModel> All();

        void Create(BuyerInfoCreateViewModel model);

        void Edit(BuyerInfoEditViewModel model);

        BuyerInfoEditViewModel Details(int? id);

        void Delete(int? id);

    }
}
