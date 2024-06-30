﻿using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<PaginatedList<CustomerTypeListViewModel>> GetAll(int pageSize, int pageNumber)
        {
            var CustomerTypeList = _context.CustomerTypes;
            var vm = CustomerTypeList.ModelToVM().AsQueryable();
            return await PaginatedList<CustomerTypeListViewModel>.CreateAsync(vm, pageSize, pageNumber);
        }
    }
}
