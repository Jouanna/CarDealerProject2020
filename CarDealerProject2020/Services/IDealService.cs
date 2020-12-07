using System;
using System.Collections.Generic;
using CarDealerProject2020.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public interface IDealService
    {
        IEnumerable<DealAllViewModel> All();

        void Create(DealCreateViewModel model);

        void Edit(DealEditViewModel model);

        DealEditViewModel Details(int? id);

        void Delete(int? id);
    }
}
