using CarDealerProject2020.Data;
using CarDealerProject2020.Data.Models;
using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public class DealService : IDealService
    {
        private readonly ApplicationDbContext dbContext;

        public DealService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<DealAllViewModel> All()
        {
            throw new NotImplementedException();
        }

        public void Create(DealCreateViewModel model)
        {
            var deal = new Deal
            {
                BuyerId = model.BuyerId,
                SellerId = model.SellerId,
                VehicleId = model.VehicleId,
                Date = model.Date,
                Discount = model.Discount,
                PaymentType = model.PaymentType,
            };

            this.dbContext.Deals.Add(deal);
            this.dbContext.SaveChanges();
        }

        public void Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public DealEditViewModel Details(int? id)
        {
            throw new NotImplementedException();
        }

        public void Edit(DealEditViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
