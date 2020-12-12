using CarDealerProject2020.Data;
using CarDealerProject2020.Data.Models;
using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public class VehicleDetailService : IVehicleDetailService
    {
        private readonly ApplicationDbContext dbContext;

        public VehicleDetailService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<VehicleDetailAllViewModel> All()
        {
            return this.dbContext.VehicleDetails
                .Select(x => new VehicleDetailAllViewModel
                {
                    Id = x.Id,
                    DetailId = x.DetailId,
                    VehicleId = x.VehicleId,
                })
                .ToList();
        }

        public void Create(VehicleDetailCreateViewModel model)
        {
            var vehicleDetail = new VehicleDetail
            {
                DetailId = model.DetailId,
                VehicleId = model.VehicleId,
            };

            this.dbContext.VehicleDetails.Add(vehicleDetail);
            this.dbContext.SaveChanges();
        }

        public void Delete(int? id)
        {
            var vehicleDetail = dbContext.VehicleDetails.Find(id);
            this.dbContext.VehicleDetails.Remove(vehicleDetail);
            this.dbContext.SaveChanges();
        }

        public VehicleDetailEditViewModel Details(int? id)
        {
            return this.dbContext.VehicleDetails.Where(x => x.Id == id)
                .Select(x => new VehicleDetailEditViewModel
                {
                    Id = x.Id,
                    DetailId = x.DetailId,
                    VehicleId = x.VehicleId,
                })
                .FirstOrDefault();
        }

        public void Edit(VehicleDetailEditViewModel model)
        {
            var vehicleDetail = new VehicleDetail
            {
                Id = model.Id,
                DetailId = model.DetailId,
                VehicleId = model.VehicleId,
            };

            this.dbContext.VehicleDetails.Update(vehicleDetail);
            this.dbContext.SaveChanges();
        }
    }
}
