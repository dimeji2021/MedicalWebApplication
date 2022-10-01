using MedicalWebApplication.Models;
using MedicalWebApplicationService.IService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MedicalWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPagination _pagination;

        public HomeController(ILogger<HomeController> logger, IPagination pagination)
        {
            _logger = logger;
            _pagination = pagination;
        }

        public async Task<IActionResult> Index(int page)
        {
            var pagination = await _pagination.Paginations(page);

            return View(pagination);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
