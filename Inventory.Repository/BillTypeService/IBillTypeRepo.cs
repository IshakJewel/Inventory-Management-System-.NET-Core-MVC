﻿using Inventory.Repository.Paging;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Repository.BillTypeService
{
    public interface IBillTypeRepo
    {
        PagedResult<BillListViewModel> GetAll(int pageSize, int pageNumber);
        void Add(CreateBillTypeViewModel model);
        void Update(BillTypeViewModel model);
        void Delete(int id);
        BillTypeViewModel GetById(int id);
    }
}
