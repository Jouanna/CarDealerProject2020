using CarDealerProject2020.Services;
using CarDealerProject2020.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealerProject2020.Controllers
{
    public class VehicleDetailController : Controller
    {
        private readonly IVehicleDetailService service;

        public VehicleDetailController(IVehicleDetailService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return this.RedirectToAction("All");
        }

        public IActionResult All()
        {
            var viewModel = this.service.All();
            return this.View(viewModel);
        }

        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VehicleDetailCreateViewModel model)
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

            return this.View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(VehicleDetailEditViewModel model)
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
