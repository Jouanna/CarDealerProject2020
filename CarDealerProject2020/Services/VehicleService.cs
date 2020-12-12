using CarDealerProject2020.Data;
using CarDealerProject2020.Data.Models;
using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDbContext dbContext;

        public VehicleService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<VehicleAllViewModel> All()
        {
            return this.dbContext.Vehicles
                .Select(x => new VehicleAllViewModel
                {
                    Id = x.Id,
                    BrandName = x.BrandName,
                })
                .ToList();
        }

        public void Create(VehicleCreateViewModel model)
        {
            var vehicle = new Vehicle
            {
                BrandName = model.BrandName,

            };

            this.dbContext.Vehicles.Add(vehicle);
            this.dbContext.SaveChanges();
        }

        public void Delete(int? id)
        {
            var vehicle = dbContext.Vehicles.Find(id);
            this.dbContext.Vehicles.Remove(vehicle);
            this.dbContext.SaveChanges();
        }

        public VehicleEditViewModel Details(int? id)
        {
            return this.dbContext.Vehicles.Where(x => x.Id == id)
                .Select(x => new VehicleEditViewModel
                {
                    Id = x.Id,
                    BrandName = x.BrandName,
                })
                .FirstOrDefault();
        }

        public void Edit(VehicleEditViewModel model)
        {
            var vehicle = new Vehicle
            {
                Id = model.Id,
                BrandName = model.BrandName,
            };

            this.dbContext.Vehicles.Update(vehicle);
            this.dbContext.SaveChanges();
        }
    }
}
