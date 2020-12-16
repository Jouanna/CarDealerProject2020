using CarDealerProject2020.Services;
using CarDealerProject2020.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Controllers
{
    public class DealController : Controller
    {
        private readonly IDealService service;
        private readonly IMemoryCache memoryCache;

        public DealController(IDealService service, IMemoryCache memoryCache)
        {
            this.service = service;
            this.memoryCache = memoryCache;
        }
        public IActionResult Index()
        {
            return this.RedirectToAction("All");
        }

        public IActionResult All()
        {
            if (!memoryCache.TryGetValue<IEnumerable<DealAllViewModel>>("AllDeals", out var viewModel))
            {
                viewModel = this.service.All();
                memoryCache.Set("AllDeals", viewModel, TimeSpan.FromMinutes(2));
            }
            return this.View(viewModel);
        }

        public IActionResult Create()
        {
            var viewModel = new DealCreateViewModel
            {
                Sellers = this.service.Sellers(),
                Buyers = this.service.Buyers(),
                Cars = this.service.Cars(),
                Date = DateTime.Now.Date,
            };
            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(DealCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.Create(model);
                return this.RedirectToAction("All");
            }
            return this.View(model);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = this.service.Details(id);

            if (viewModel == null)
            {
                return NotFound();
            }
            viewModel.Sellers = service.Sellers();
            viewModel.Buyers = service.Buyers();
            viewModel.Cars = service.Cars();
            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(DealEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                this.service.Edit(model);
                return this.RedirectToAction("All");
            }
            return this.View(model);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = this.service.Details(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return this.View(viewModel);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viewModel = this.service.Details(id);

            if (viewModel == null)
            {
                return NotFound();
            }

            return this.View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            this.service.Delete(id);
            return this.RedirectToAction("All");
        }
    }
}
