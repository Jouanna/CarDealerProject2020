using CarDealerProject2020.Data;
using CarDealerProject2020.Data.Models;
using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public class BuyerInfoService : IBuyerInfoService
    {
        private readonly ApplicationDbContext dbContext;

        public BuyerInfoService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<BuyerInfoAllViewModel> All()
        {
            return this.dbContext.BuyersInfos
                .Select(x => new BuyerInfoAllViewModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName = x.LastName,
                    City = x.City,
                    Address = x.Address,
                    Phone = x.Phone,
                    DriverLicenseNumber = x.DriverLicenseNumber,
                })
                .ToList();
        }

        public void Create(BuyerInfoCreateViewModel model)
        {
            var buyerInfo = new BuyerInfo
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                City = model.City,
                Address = model.Address,
                Phone = model.Phone,
                DriverLicenseNumber = model.DriverLicenseNumber,
            };

            this.dbContext.BuyersInfos.Add(buyerInfo);
            this.dbContext.SaveChanges();
        }

        public void Edit(BuyerInfoEditViewModel model)
        {
            var buyerInfo = new BuyerInfo
            {
                Id = model.Id,
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                City = model.City,
                Address = model.Address,
                Phone = model.Phone,
                DriverLicenseNumber = model.DriverLicenseNumber,
            };

            //this.dbContext.Update(buyerInfo);
            this.dbContext.BuyersInfos.Update(buyerInfo);
            this.dbContext.SaveChanges();
        }

        public BuyerInfoEditViewModel Details(int? id)
        {
            return this.dbContext.BuyersInfos.Where(x => x.Id == id)
                .Select(x => new BuyerInfoEditViewModel
                {
                    Id = x.Id,
                    FirstName = x.FirstName,
                    MiddleName = x.MiddleName,
                    LastName = x.LastName,
                    City = x.City,
                    Address = x.Address,
                    Phone = x.Phone,
                    DriverLicenseNumber = x.DriverLicenseNumber,
                })
                .FirstOrDefault();

        }

        public void Delete(int? id)
        {
            var buyerInfo = dbContext.BuyersInfos.Find(id);
            this.dbContext.BuyersInfos.Remove(buyerInfo);
            this.dbContext.SaveChanges();
        }


    }
}
