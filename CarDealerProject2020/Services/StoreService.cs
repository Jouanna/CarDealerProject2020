using CarDealerProject2020.Data;
using CarDealerProject2020.Data.Models;
using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public class StoreService : IStoreService
    {
        private readonly ApplicationDbContext dbContext;

        public StoreService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<StoreAllViewModel> All()
        {
            return this.dbContext.Stores
                .Select(x => new StoreAllViewModel
                {
                    Id = x.Id,
                    StoreName = x.StoreName,
                    City = x.City,
                    Address = x.Address,
                })
                .ToList();
        }

        public void Create(StoreCreateViewModel model)
        {
            var store = new Store
            {
                StoreName = model.StoreName,
                City = model.City,
                Address = model.Address,
            };

            this.dbContext.Stores.Add(store);
            this.dbContext.SaveChanges();
        }

        public void Delete(int? id)
        {
            var store = dbContext.Stores.Find(id);
            this.dbContext.Stores.Remove(store);
            this.dbContext.SaveChanges();
        }

        public StoreEditViewModel Details(int? id)
        {
            return this.dbContext.Stores.Where(x => x.Id == id)
                .Select(x => new StoreEditViewModel
                {
                    Id = x.Id,
                    StoreName = x.StoreName,
                    City = x.City,
                    Address = x.Address,
                })
                .FirstOrDefault();
        }

        public void Edit(StoreEditViewModel model)
        {
            var store = new Store
            {
                Id = model.Id,
                StoreName = model.StoreName,
                City = model.City,
                Address = model.Address,
            };

            this.dbContext.Stores.Update(store);
            this.dbContext.SaveChanges();
        }
    }
}
