using CarDealerProject2020.Data;
using CarDealerProject2020.Services;
using CarDealerProject2020.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CarDealerPorject2020.Test
{
    public class DetailTests
    {
        [Fact]
        public void DetailTestCreate()
        {
            //arrange
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new DetailService(dbContext);

            //act
            var model = new DetailCreateViewModel
            {
                Type = "лек автомобил",
                Model = "S500",
            };
            service.Create(model);
            //assert
            Assert.NotNull(dbContext);
        }

        [Fact]
        public void DetailTestEdit()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb1");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new DetailService(dbContext);

            var model = new DetailEditViewModel
            {
                Type = "лек автомобил",
                Model = "S500",
            };
            service.Edit(model);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void DetailTestDelete()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb2");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new DetailService(dbContext);

            var model = new DetailCreateViewModel
            {
                Type = "лек автомобил",
                Model = "S500",
            };
            service.Create(model);

            service.Delete(1);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void DetailTestAll()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb3");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new DetailService(dbContext);

            var model = new DetailCreateViewModel
            {
                Type = "лек автомобил",
                Model = "S500",
            };
            service.Create(model);

            service.All();

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void DetailTestDetails()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb4");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new DetailService(dbContext);

            var model = new DetailCreateViewModel
            {
                Type = "лек автомобил",
                Model = "S500",
            };
            service.Create(model);

            service.Details(1);

            Assert.NotNull(dbContext);
        }
    }
}
