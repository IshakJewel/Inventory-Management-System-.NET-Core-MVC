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

        public IActionResult Index(int pageSize, int PageNumber)
        {

            return View();
        }
    }
}
