using CarDealerProject2020.Data;
using CarDealerProject2020.Services;
using CarDealerProject2020.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CarDealerPorject2020.Test
{
    public class SellerInfoTests
    {
        [Fact]
        public void SellerInfoTestCreate()
        {
            //arrange
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new SellerInfoService(dbContext);

            //act
            var model = new SellerInfoCreateViewModel
            {
                Name = "Jouanna",
                StoreId = 1,
            };
            service.Create(model);
            //assert
            Assert.NotNull(dbContext);
        }

        [Fact]
        public void SellerInfoTestEdit()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb1");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new SellerInfoService(dbContext);

            var model = new SellerInfoEditViewModel
            {
                Name = "Jouanna",
                StoreId = 1,
            };
            service.Edit(model);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void SellerInfoTestDelete()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb2");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new SellerInfoService(dbContext);

            var model = new SellerInfoCreateViewModel
            {
                Name = "Jouanna",
                StoreId = 1,
            };
            service.Create(model);

            service.Delete(1);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void SellerInfoTestAll()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb3");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new SellerInfoService(dbContext);

            var model = new SellerInfoCreateViewModel
            {
                Name = "Jouanna",
                StoreId = 1,
            };
            service.Create(model);

            service.All();

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void SellerInfoTestDetails()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb4");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new SellerInfoService(dbContext);

            var model = new SellerInfoCreateViewModel
            {
                Name = "Jouanna",
                StoreId = 1,
            };
            service.Create(model);

            service.Details(1);

            Assert.NotNull(dbContext);
        }
    }
}
