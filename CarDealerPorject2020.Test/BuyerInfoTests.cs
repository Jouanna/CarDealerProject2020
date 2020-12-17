using CarDealerProject2020.Data;
using CarDealerProject2020.Services;
using CarDealerProject2020.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CarDealerPorject2020.Test
{
    public class BuyerInfoTests
    {
        [Fact]
        public void BuyerInfoTestCreate()
        {
            //arrange
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new BuyerInfoService(dbContext);

            //act
            var model = new BuyerInfoCreateViewModel
            {
                FirstName = "Jouanna",
                LastName = "Stancheva",
                City = "Ruse",
            };
            service.Create(model);
            //assert
            Assert.NotNull(dbContext);
        }

        [Fact]
        public void BuyerInfoTestEdit()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb1");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new BuyerInfoService(dbContext);

            var model = new BuyerInfoEditViewModel
            {
                FirstName = "Jouanna",
                LastName = "Stancheva",
                City = "Ruse",
            };
            service.Edit(model);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void BuyerInfoTestDelete()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb2");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new BuyerInfoService(dbContext);

            var model = new BuyerInfoCreateViewModel
            {
                FirstName = "Jouanna",
                LastName = "Stancheva",
                City = "Ruse",
            };
            service.Create(model);

            service.Delete(1);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void BuyerInfoTestAll()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb3");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new BuyerInfoService(dbContext);

            var model = new BuyerInfoCreateViewModel
            {
                FirstName = "Jouanna",
                LastName = "Stancheva",
                City = "Ruse",
            };
            service.Create(model);

            service.All();

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void BuyerInfoTestDetails()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb4");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new BuyerInfoService(dbContext);

            var model = new BuyerInfoCreateViewModel
            {
                FirstName = "Jouanna",
                LastName = "Stancheva",
                City = "Ruse",
            };
            service.Create(model);

            service.Details(1);

            Assert.NotNull(dbContext);
        }
    }
}
