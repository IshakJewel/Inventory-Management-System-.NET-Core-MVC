using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillTypeService
{
    public class BillTypeRepo : IBillTypeRepo
    {
        private ApplicationDbContext _context;
        public BillTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<BillTypeListModel>> GetAll(int pageSize, int pageNumber)
        {
            var BillTypeList = _context.BillTypes;
            var vm = BillTypeList.ModelToVM().AsQueryable();
            return await PaginatedList<BillTypeListModel>.CreateAsync(vm, pageSize, pageNumber);
        }
    }
}
