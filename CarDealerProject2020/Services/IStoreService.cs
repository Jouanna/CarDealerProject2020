using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public interface IStoreService
    {
        IEnumerable<StoreAllViewModel> All();

        void Create(StoreCreateViewModel model);

        void Edit(StoreEditViewModel model);

        StoreEditViewModel Details(int? id);

        void Delete(int? id);
    }
}
