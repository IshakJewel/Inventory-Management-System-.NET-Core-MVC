using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Vendor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.VendorTypeService
{
    public interface IVendorTypeRepo
    {
        PagedResult<VendorTypeViewModel> GetAll(int pageSize, int pageNumber);
        void Add(CreateVendorTypeListViewModel model);
        void Update(VendorTypeViewModel model);
        void Delete(int id);
        VendorTypeViewModel GetById(int id);
    }
}
