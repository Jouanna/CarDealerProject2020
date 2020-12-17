using CarDealerProject2020.Data;
using CarDealerProject2020.Services;
using CarDealerProject2020.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace CarDealerPorject2020.Test
{
    public class StoreTests
    {
        [Fact]
        public void StoreTestCreate()
        {
            //arrange
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new StoreService(dbContext);

            //act
            var model = new StoreCreateViewModel
            {
                StoreName = "Магазин на мерцедес",
                City = "Русе",
            };
            service.Create(model);
            //assert
            Assert.NotNull(dbContext);
        }

        [Fact]
        public void StoreTestEdit()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb1");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new StoreService(dbContext);

            var model = new StoreEditViewModel
            {
                StoreName = "Магазин на мерцедес",
                City = "Русе",
            };
            service.Edit(model);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void StoreTestDelete()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb2");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new StoreService(dbContext);

            var model = new StoreCreateViewModel
            {
                StoreName = "Магазин на мерцедес",
                City = "Русе",
            };
            service.Create(model);

            service.Delete(1);

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void StoreTestAll()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb3");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new StoreService(dbContext);

            var model = new StoreCreateViewModel
            {
                StoreName = "Магазин на мерцедес",
                City = "Русе",
            };
            service.Create(model);

            service.All();

            Assert.NotNull(dbContext);
        }
        [Fact]
        public void StoreTestDetails()
        {
            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestDb4");

            var dbContext = new ApplicationDbContext(optionBuilder.Options);

            var service = new StoreService(dbContext);

            var model = new StoreCreateViewModel
            {
                StoreName = "Магазин на мерцедес",
                City = "Русе",
            };
            service.Create(model);

            service.Details(1);

            Assert.NotNull(dbContext);
        }
    }
}
