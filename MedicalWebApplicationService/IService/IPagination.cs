using MedicalWebApplicationService.ViewModel;
using System.Threading.Tasks;

namespace MedicalWebApplicationService.IService
{
    public interface IPagination
    {
        Task<PaginationViewModel> Paginations(int page);
    }
}