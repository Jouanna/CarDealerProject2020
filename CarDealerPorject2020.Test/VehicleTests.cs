using CarDealerProject2020.Data;
using CarDealerProject2020.Services;
using CarDealerProject2020.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CarDealerPorject2020.Test
{
    public class VehicleTests
    {
        [Fact]
        public void VehicleTestCreate()
        {
            //arrange
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new VehicleService(dbContext);

            //act
            var model = new VehicleCreateViewModel
            {
                BrandName = "Мерцедес",
            };
            service.Create(model);
            //assert
            Assert.NotNull(dbContext);
        }

        [Fact]
        public void VehicleTestEdit()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb1");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new VehicleService(dbContext);

            var model = new VehicleEditViewModel
            {
                BrandName = "Мерцедес",
            };
            service.Edit(model);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void VehicleTestDelete()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb2");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new VehicleService(dbContext);

            var model = new VehicleCreateViewModel
            {
                BrandName = "Мерцедес",
            };
            service.Create(model);

            service.Delete(1);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void VehicleTestAll()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb3");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new VehicleService(dbContext);

            var model = new VehicleCreateViewModel
            {
                BrandName = "Мерцедес",
            };
            service.Create(model);

            service.All();

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void VehicleTestDetails()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb4");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new VehicleService(dbContext);

            var model = new VehicleCreateViewModel
            {
                BrandName = "Мерцедес",
            };
            service.Create(model);

            service.Details(1);

            Assert.NotNull(dbContext);
        }
    }
}
