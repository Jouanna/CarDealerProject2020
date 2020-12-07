using CarDealerProject2020.Data;
using CarDealerProject2020.Data.Models;
using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public class DetailService : IDetailService
    {
        private readonly ApplicationDbContext dbContext;

        public DetailService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<DetailAllViewModel> All()
        {
            return this.dbContext.Details
                .Select(x => new DetailAllViewModel
                {
                    Id = x.Id,
                    Type = x.Type,
                    Model = x.Model,
                    Year = x.Year,
                    Fuel = x.Fuel,
                    HorsePower = x.HorsePower,
                    Color = x.Color,
                    Price = x.Price,
                    StoreId = x.StoreId,
                })
                .ToList();
        }

        public void Create(DetailCreateViewModel model)
        {
            var detail = new Detail
            {
                Type = model.Type,
                Model = model.Model,
                Year = model.Year,
                Fuel = model.Fuel,
                HorsePower = model.HorsePower,
                Color = model.Color,
                Price = model.Price,
                StoreId = model.StoreId,
            };

            this.dbContext.Details.Add(detail);
            this.dbContext.SaveChanges();
        }

        public void Delete(int? id)
        {
            var detail = dbContext.Details.Find(id);
            this.dbContext.Details.Remove(detail);
            this.dbContext.SaveChanges();
        }

        public DetailEditViewModel Details(int? id)
        {
            return this.dbContext.Details.Where(x => x.Id == id)
                .Select(x => new DetailEditViewModel
                {
                    Id = x.Id,
                    Type = x.Type,
                    Model = x.Model,
                    Year = x.Year,
                    Fuel = x.Fuel,
                    HorsePower = x.HorsePower,
                    Color = x.Color,
                    Price = x.Price,
                    StoreId = x.StoreId,
                })
                .FirstOrDefault();
        }

        public void Edit(DetailEditViewModel model)
        {
            var detail = new Detail
            {
                Id = model.Id,
                Type = model.Type,
                Model = model.Model,
                Year = model.Year,
                Fuel = model.Fuel,
                HorsePower = model.HorsePower,
                Color = model.Color,
                Price = model.Price,
                StoreId = model.StoreId,
            };

            this.dbContext.Details.Update(detail);
            this.dbContext.SaveChanges();
        }
    }
}
