using MedicalWebApplicationService.IService;
using MedicalWebApplicationService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWebApplicationService.Service
{
    public class PaginationService : IPagination
    {
        private readonly IProductService _productService;
        private readonly IResearchStatisticsService _researchStatisticsService;
        private readonly IDoctorService _doctorServices;
        public PaginationService(IProductService productService, IResearchStatisticsService researchStatisticsService, IDoctorService doctorServices)
        {
            _productService = productService;
            _researchStatisticsService = researchStatisticsService;
            _doctorServices = doctorServices;
        }
        public async Task<PaginationViewModel> Paginations(int page)
        {
            PaginationViewModel paginationViewModel = new PaginationViewModel();
            var products = await _productService.GetAllProducts();
            /*------------------------------------------------------------------------------*/
            paginationViewModel.PageSize = 4;
            paginationViewModel.CurrentPage = page == 0 ? 1 : page;

            double pages = (double)products.Count / paginationViewModel.PageSize;
            paginationViewModel.NumberPages = (int)Math.Round(pages, 0, MidpointRounding.AwayFromZero);
            var skip = 4 * (Convert.ToInt32(paginationViewModel.CurrentPage) - 1);
            paginationViewModel.Products = products.Skip(skip).Take(paginationViewModel.PageSize).ToList();

            if (paginationViewModel.CurrentPage == 1)
            {
                paginationViewModel.PreviousPage = 0;
            }
            else
            {
                paginationViewModel.PreviousPage = paginationViewModel.CurrentPage - 1;
            }
            if (paginationViewModel.CurrentPage <= pages)
            {
                paginationViewModel.NextPage = paginationViewModel.CurrentPage + 1;
            }
            paginationViewModel.Research = await _researchStatisticsService.Calstat();
            paginationViewModel.Doctors = await _doctorServices.GetAllDoctorsAsync();
            paginationViewModel.CarouselProducts = await _productService.GetAllProducts();
            return paginationViewModel;
        }
    }
}
