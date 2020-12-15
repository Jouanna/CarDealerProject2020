using CarDealerProject2020.Data;
using CarDealerProject2020.Data.Models;
using CarDealerProject2020.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Services
{
    public class SellerInfoService : ISellerInfoService
    {
        private readonly ApplicationDbContext dbContext;

        public SellerInfoService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<SellerInfoAllViewModel> All()
        {
            return this.dbContext.SellerInfos
                .Select(x => new SellerInfoAllViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    StoreId = x.StoreId,
                    StoreName = x.Store.StoreName,
                })
                .ToList();
        }

        public void Create(SellerInfoCreateViewModel model)
        {
            var sellerInfo = new SellerInfo
            {
                Name = model.Name,
                StoreId = model.StoreId,
            };

            this.dbContext.SellerInfos.Add(sellerInfo);
            this.dbContext.SaveChanges();
        }

        public void Delete(int? id)
        {
            var sellerInfo = dbContext.SellerInfos.Find(id);
            this.dbContext.SellerInfos.Remove(sellerInfo);
            this.dbContext.SaveChanges();
        }

        public SellerInfoEditViewModel Details(int? id)
        {
            return this.dbContext.SellerInfos.Where(x => x.Id == id)
                .Select(x => new SellerInfoEditViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    StoreId = x.StoreId,
                    StoreName = x.Store.StoreName,
                })
                .FirstOrDefault();
        }

        public void Edit(SellerInfoEditViewModel model)
        {
            var sellerInfo = new SellerInfo
            {
                Id = model.Id,
                Name = model.Name,
                StoreId = model.StoreId,
            };

            this.dbContext.SellerInfos.Update(sellerInfo);
            this.dbContext.SaveChanges();
        }

        public IEnumerable<KeyValuePair<string, string>> Stores()
        {
            return this.dbContext.Stores.Select(x => new
            {
                Id = x.Id.ToString(),
                Name = x.StoreName + " " + x.Id,
            })
                .ToList()
                .Select(x => new KeyValuePair<string, string>(x.Id, x.Name));
        }
    }
}
