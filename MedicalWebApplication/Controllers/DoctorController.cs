using MedicalWebApplicationService.IService;
using MedicalWebApplicationService.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace MedicalWebApplication.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorService _doctorServices;
        private readonly IPagination _pagination;
        IProductService _productService;

        public DoctorController(IDoctorService doctorServices, IPagination pagination, IProductService productService)
        {
            _doctorServices = doctorServices;
            _pagination = pagination;
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Doctor(int id)
        {

            return View(await _doctorServices.GetDoctorById(id));
        }

        public async Task<IActionResult> DoctorIndex(int page)
        {
            var pagination = await _pagination.Paginations(page);

            return View(pagination);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(PostViewModel post)
        {
            if (ModelState.IsValid)
            {
                var hasAdd = await _productService.AddProduct(post);
                if (hasAdd)
                {
                    ModelState.Clear();
                    return View();
                }
            }
            ModelState.AddModelError(string.Empty, "An error occur, try again latter");
            return View();
        }
        public async Task<IActionResult> DeleteProduct(Guid Id)
        {
                var isDeleted = await _productService.DeleteProduct(Id);
                if (isDeleted)
                {
                    return RedirectToAction("Products");
                }
                return View();
        }
        public async Task<IActionResult> Products(int page)
        {
            var pagination = await _pagination.Paginations(page);

            return View(pagination);
        }
        [HttpPost]
        public async Task<IActionResult> Update(PostViewModel post)
        {
            if (ModelState.IsValid)
            {
                var hasAdd = await _productService.AddProduct(post);
                if (hasAdd)
                {
                    return View();
                }
            }
            ModelState.AddModelError(string.Empty, "An error occur, try again latter");
            return View();
        }

    }
}
