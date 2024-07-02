using Inventory.Repository.BillTypeService;
using Inventory.ViewModel.Bill;
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
        [HttpGet]
        public async Task<IActionResult> Index(int pageSize = 10, int PageNumber = 1)
        {
            var billTypes = await _billTypeRepo.GetAll(PageNumber, pageSize);
            return View(billTypes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBillTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _billTypeRepo.Add(model);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _billTypeRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(BillTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _billTypeRepo.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _billTypeRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
