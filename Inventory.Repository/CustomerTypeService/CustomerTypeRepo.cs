using Inventory.Models;
using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.CustomerTypeService
{
    public class CustomerTypeRepo : ICustomerTypeRepo
    {
        private ApplicationDbContext _context;
        public CustomerTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public PagedResult<CustomerTypeListViewModel> GetAll(int pageSize, int pageNumber)
        {
            int totalCount = 0;
            List<CustomerTypeListViewModel> vmList=new List<CustomerTypeListViewModel>();
            try
            {
                int ExcludeRecords = ((pageSize * pageNumber) - pageSize);
                var modelList = _context.CustomerTypes.
                    Skip(ExcludeRecords).Take(ExcludeRecords).ToList();
                totalCount = _context.BillTypes.ToList().Count;
                vmList = CustomerTypeListViewModel(modelList);
            }
            catch (Exception ex)
            {

                throw;
            }
            var result = new PagedResult<CustomerTypeListViewModel>
            {
                Data = vmList,
                TotalItems = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
        public void Add(CreateCustomerTypeViewModel vm)
        {
            var model = new CreateCustomerTypeViewModel().Convert(vm);
            _context.CustomerTypes.Add(model);
            _context.SaveChanges();
           
        }
        public void Delete(int id)
        {
            var model = _context.CustomerTypes.Find(id);
            if (model != null) {
            _context.CustomerTypes.Remove(model);
            _context.SaveChanges();
            }
        }
        public CustomerTypeViewModel GetById(int id)
        {
            var model = _context.CustomerTypes.Find(id);
            var vm = new CustomerTypeViewModel(model);
            return vm;

        }
        public void Update(CustomerTypeViewModel vm)
        {
           var model = _context.CustomerTypes.Where(x=>x.CustomerTypeId==vm.CustomerTypeId).FirstOrDefault();
            if (model != null)
            {
                model.CustomerTypeName = vm.CustomerTypeName;
                model.Description = vm.Description;
            }
            _context.SaveChanges();
        }
    }
}
