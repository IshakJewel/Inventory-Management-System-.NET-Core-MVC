using Inventory.Repository.CustomerTypeService;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Web.Controllers
{
    public class CustomerTypeController : Controller
    {
        private ICustomerTypeRepo _customerTypeRepo;
        public CustomerTypeController(ICustomerTypeRepo customerTypeRepo)
        {
            _customerTypeRepo = customerTypeRepo;
        }
        [HttpGet]
        public IActionResult Index(int pageSize = 10, int PageNumber = 1)
        {
            var customerTypes = _customerTypeRepo.GetAll(pageSize, PageNumber);
            return View(customerTypes);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateCustomerTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _customerTypeRepo.Add(model);
            }
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _customerTypeRepo.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(CustomerTypeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _customerTypeRepo.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _customerTypeRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
