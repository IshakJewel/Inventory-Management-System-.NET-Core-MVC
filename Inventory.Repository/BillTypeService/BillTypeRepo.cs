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

namespace Inventory.Repository.BillTypeService
{
    public class BillTypeRepo : IBillTypeRepo
    {
        private ApplicationDbContext _context;
        public BillTypeRepo(ApplicationDbContext context)
        {
            _context = context;
        }
        //public async Task<PaginatedList<BillTypeListModel>> GetAll(int pageNumber, int pageSize)
        //{
        //    var BillTypeList = _context.BillTypes;
        //    var vm = BillTypeList.ModelToVM().AsQueryable();
        //    return await PaginatedList<BillTypeListModel>.CreateAsync(vm, pageNumber, pageSize);
        //}
       
        public void Add(CreateBillTypeViewModel model)
        {
            var BillTypeList = model.VMToModel();
            _context.BillTypes.Add(BillTypeList);
            _context.SaveChanges();
        }
        public void Update(BillTypeViewModel vm)
        {
            var model = _context.BillTypes.Where(x=>x.BillTypeId==vm.BillTypeId).FirstOrDefault();
            if (model!=null)
            { 
                model.BillTypeName = vm.BillTypeName;
                model.Description = vm.Description;
            }
            _context.SaveChanges();
            
        }
        public void Delete(int id)
        {
            var model = _context.BillTypes.Where(x => x.BillTypeId == id).FirstOrDefault();
            if (model != null)
            {
                _context.BillTypes.Remove(model);
            }
            _context.SaveChanges();
        }

        public BillTypeViewModel GetById(int id)
        {
            var model = _context.BillTypes.Where(x => x.BillTypeId == id).FirstOrDefault();
            var vm = new BillTypeViewModel(model);
            return vm;
        }

        public PagedResult<BillListViewModel> GetAll(int pageSize, int pageNumber)
        {
            var BillTypeList = _context.BillTypes;
            var vm = BillTypeList.ModelToVM().AsQueryable();
            return  PagedResult<BillTypeListModel>.CreateAsync(vm, pageNumber, pageSize);
        }
    }
}
