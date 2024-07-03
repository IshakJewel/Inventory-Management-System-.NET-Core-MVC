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
        //public async Task<PaginatedList<CustomerTypeListViewModel>> GetAll(int pageSize, int pageNumber)
        //{
        //    var CustomerTypeList = _context.CustomerTypes;
        //    var vm = CustomerTypeList.ModelToVM().AsQueryable();
        //    return await PaginatedList<CustomerTypeListViewModel>.CreateAsync(vm, pageSize, pageNumber);
        //}

        public PagedResult<CustomerTypeListViewModel> GetAll(int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }
        public void Add(CreateCustomerTypeViewModel vm)
        {
            var model = new CreateCustomerTypeViewModel().Convert(vm);
            _context.CustomerTypes.Add(model);
            _context.SaveChanges();
           
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        public CustomerTypeViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerTypeViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
