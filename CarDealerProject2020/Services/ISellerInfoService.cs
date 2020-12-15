using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public interface ISellerInfoService
    {
        IEnumerable<SellerInfoAllViewModel> All();

        void Create(SellerInfoCreateViewModel model);

        void Edit(SellerInfoEditViewModel model);

        SellerInfoEditViewModel Details(int? id);

        void Delete(int? id);

        IEnumerable<KeyValuePair<string, string>> Stores();
    }
}
