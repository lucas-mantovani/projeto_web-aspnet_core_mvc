using Microsoft.AspNetCore.Mvc;
using mvc_project.Models;
using mvc_project.Models.Enums;
using mvc_project.Models.ViewModels;
using mvc_project.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_project.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _salesRecordsService;
        private readonly SellerService _sellerService;

        public SalesRecordsController(SalesRecordService salesRecordsService, SellerService sellerService)
        {
            _salesRecordsService = salesRecordsService;
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Create()
        {
            var sellers = await _sellerService.FindAllAsync();
            var viewModel = new SaleFormViewModel { sellers = sellers};
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SalesRecord salesRecord)
        {
            if (ModelState.IsValid)
            {
                var sellers = await _sellerService.FindAllAsync();
                var viewModel = new SaleFormViewModel { sellers = sellers };
                return View(viewModel);
            }
            salesRecord.Seller = await _sellerService.FindByIdAsync(salesRecord.Seller.Id);
            
            await _salesRecordsService.InsertAsync(salesRecord);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (minDate.HasValue)
            {
                ViewData["minDate"] = minDate.Value.ToString("dd-MM-yyyy");
            }
            if (maxDate.HasValue)
            {
                ViewData["maxDate"] = maxDate.Value.ToString("dd-MM-yyyy");
            }

            var result = await _salesRecordsService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }

        public async Task<IActionResult> GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (minDate.HasValue)
            {
                ViewData["minDate"] = minDate.Value.ToString("dd-MM-yyyy");
            }
            if (maxDate.HasValue)
            {
                ViewData["maxDate"] = maxDate.Value.ToString("dd-MM-yyyy");
            }

            var result = await _salesRecordsService.FindByDateGroupingAsync(minDate, maxDate);
            return View(result);
        }
    }
}
