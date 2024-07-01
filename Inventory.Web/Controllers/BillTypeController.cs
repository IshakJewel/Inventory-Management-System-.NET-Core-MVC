using Inventory.Repository.BillTypeService;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Web.Controllers
{
    public class BillTypeController : Controller
    {
        private IBillTypeRepo _billTypeRepo;

        public BillTypeController(IBillTypeRepo billTypeRepo)
        {
            _billTypeRepo = billTypeRepo;
        }

        public async Task<IActionResult> Index(int pageSize=10, int PageNumber=1)
        {
            var billTypes = await _billTypeRepo.GetAll(pageSize, PageNumber);
            return View(billTypes);
        }
    }
}
