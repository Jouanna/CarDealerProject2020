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
            return this.dbContext.Deals
                .Select(x => new DealAllViewModel
                {
                    Id = x.Id,
                    BuyerId = x.BuyerId,
                    SellerId = x.SellerId,
                    VehicleId = x.VehicleId,
                    Date = x.Date,
                    Discount = x.Discount,
                    PaymentType = x.PaymentType,
                })
                .ToList();
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
            var deal = dbContext.Deals.Find(id);
            this.dbContext.Deals.Remove(deal);
            this.dbContext.SaveChanges();
        }

        public DealEditViewModel Details(int? id)
        {
            return this.dbContext.Deals.Where(x => x.Id == id)
                .Select(x => new DealEditViewModel
                {
                    Id = x.Id,
                    BuyerId = x.BuyerId,
                    SellerId = x.SellerId,
                    VehicleId = x.VehicleId,
                    Date = x.Date,
                    Discount = x.Discount,
                    PaymentType = x.PaymentType,
                })
                .FirstOrDefault();
        }

        public void Edit(DealEditViewModel model)
        {
            var deal = new Deal
            {
                Id = model.Id,
                BuyerId = model.BuyerId,
                SellerId = model.SellerId,
                VehicleId = model.VehicleId,
                Date = model.Date,
                Discount = model.Discount,
                PaymentType = model.PaymentType,
            };

            this.dbContext.Deals.Update(deal);
            this.dbContext.SaveChanges();
        }
    }
}
