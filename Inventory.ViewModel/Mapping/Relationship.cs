using Inventory.Models;
using Inventory.ViewModel.Bill;
using Inventory.ViewModel.Customer;
using Inventory.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Mapping
{
    public static class Relationship
    {
        public static IEnumerable<CustomerTypeListViewModel> 
            ModelToVM(this IEnumerable<Inventory.Models.CustomerType> customerTypes)
        {
            List<CustomerTypeListViewModel> list= new List<CustomerTypeListViewModel>();
            foreach (var ct in customerTypes)
            {
                list.Add(new CustomerTypeListViewModel()
                {
                    CustomerTypeId = ct.CustomerTypeId,
                    CustomerTypeName = ct.CustomerTypeName,
                    Description = ct.Description
                });
                
            }
            return list;
        }

        public static IEnumerable<CustomerListViewModel>
            ModelToVM(this IEnumerable<Inventory.Models.Customer> customers)
        {
            List<CustomerListViewModel> list = new List<CustomerListViewModel>();
            foreach (var ct in customers)
            {
                list.Add(new CustomerListViewModel()
                {
  
                });

            }
            return list;
        }

        public static IEnumerable<BillTypeListModel>
            ModelToVM(this IEnumerable<Inventory.Models.BillType> billTypes)
        {
            List<BillTypeListModel> list = new List<BillTypeListModel>();
            foreach (var ct in billTypes)
            {
                list.Add(new BillTypeListModel()
                {
                    BillTypeId = ct.BillTypeId,
                    BillTypeName = ct.BillTypeName,
                    Description= ct.Description
                });

            }
            return list;
        }
        public static IEnumerable<BillListViewModel>
            ModelToVM(this IEnumerable<Inventory.Models.Bill> bills)
        {
            List<BillListViewModel> list = new List<BillListViewModel>();
            foreach (var ct in bills)
            {
                list.Add(new BillListViewModel()
                {
                });
            }
            return list;
        }
        public static IEnumerable<ProductTypeListViewModel> 
            ModelToVM(this IEnumerable<Inventory.Models.ProductType> productTypes)
        {
            List<ProductTypeListViewModel> list=new List<ProductTypeListViewModel>();
            foreach (var ct in productTypes)
            {
                list.Add(new ProductTypeListViewModel()
                {

                });
            }
            return list;
        }
    }
}
