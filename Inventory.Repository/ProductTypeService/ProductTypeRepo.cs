using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Mapping;
using Inventory.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.ProductTypeService
{
    public class ProductTypeRepo : IProductTypeRepo
    {
        private ApplicationDbContext _context;
        public ProductTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PaginatedList<ProductTypeListViewModel>> GetAll(int pageSize, int pageNumber)
        {
            var ProductTypeLists = _context.ProductTypes;
            var vm = ProductTypeLists.ModelToVM().AsQueryable();
            return await PaginatedList<ProductTypeListViewModel>.CreateAsync(vm, pageSize, pageNumber);

        }
    }
}
